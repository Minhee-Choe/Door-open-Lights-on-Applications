#include "helloaccel.h"

/* constants */

/* global variables */
sensor_h gSensorAccel;
sensor_listener_h gListenerAccel;
bool gSensorSupported[1];
bool isRunning = false;
int fileCount = 0, gAccelCount = 0;
unsigned long long gAccelTimeArray[BIG_NUMBER];
float gAccelValueArray[BIG_NUMBER][3];

sensor_h gyroSensorAccel;
sensor_listener_h gyroListenerAccel;
bool gyroSensorSupported[1];
bool isGyroRunning = false;
int gyroAccelCount = 0;
unsigned long long gyroAccelTimeArray[BIG_NUMBER];
float gyroAccelValueArray[BIG_NUMBER][3];

/* Define callback */
void
example_sensor_callback(sensor_h sensor, sensor_event_s *event, appdata_s *ad)
{
	char tmp_txt[100];
	unsigned long long elapsedTime = 0;
	int skipped_sample = 0;
	double frequency;
	/* If a callback function is used to listen to different sensor types, it can check the sensor type */
	sensor_type_e type;
	sensor_get_type(sensor, &type);

	if (type == SENSOR_ACCELEROMETER) {
		unsigned long long timestamp = event->timestamp;
		gAccelTimeArray[gAccelCount] = gAccelCount*10;
		for(int i = 0; i < 3; i++) {
			gAccelValueArray[gAccelCount][i] = event->values[i];
		}
		gAccelCount++;

		sprintf(tmp_txt, "<font_size=15>Accel:[X] %.3f</font>", event->values[0]);
		elm_object_text_set(ad->txt_senx, tmp_txt);

		sprintf(tmp_txt, "<font_size=15>Accel:[Y] %.3f</font>", event->values[1]);
		elm_object_text_set(ad->txt_seny, tmp_txt);

		sprintf(tmp_txt, "<font_size=15>Accel:[Z] %.3f</font>", event->values[2]);
		elm_object_text_set(ad->txt_senz, tmp_txt);

		//Frequency calculation
		if(gAccelCount > FREQUENCY_SAMPLES + 10) {
			for(int i = gAccelCount - 1; i > gAccelCount - 1 - FREQUENCY_SAMPLES; i--) {
				if(gAccelTimeArray[i] > gAccelTimeArray[i-1]) {
					if((gAccelTimeArray[i] - gAccelTimeArray[i-1]) > 5000000) {
						//treat as an outlier
						skipped_sample = skipped_sample + 1;
					}
					elapsedTime = elapsedTime + (gAccelTimeArray[i] - gAccelTimeArray[i-1]);
				} else {
					//error
					skipped_sample = skipped_sample + 1;
				}
			}
			//Assume: the unit of timestamp is microsecond
			if(skipped_sample < FREQUENCY_SAMPLES) {
				frequency = (double)1000000.0 * (FREQUENCY_SAMPLES - skipped_sample) / elapsedTime;
			} else {
				frequency = 0;
			}

			sprintf(tmp_txt, "<font_size=15>Freq: %.2f</font>", frequency);
			elm_object_text_set(ad->txt_freq, tmp_txt);
		} else {
			sprintf(tmp_txt, "<font_size=15>Freq: Estimating...</font>");
			elm_object_text_set(ad->txt_freq, tmp_txt);
		}
	}
	else if(type == SENSOR_GYROSCOPE) {

		unsigned long long timestamp = event->timestamp;
		gyroAccelTimeArray[gyroAccelCount] = gyroAccelCount*10;
		for(int i = 0; i < 3; i++) {
			gyroAccelValueArray[gyroAccelCount][i] = event->values[i];
		}
		gyroAccelCount++;

		sprintf(tmp_txt, "<font_size=15>Gyro:[X] %.3f</font>", event->values[0]);
		elm_object_text_set(ad->txt_gyrox, tmp_txt);

		sprintf(tmp_txt, "<font_size=15>Gyro:[Y] %.3f</font>", event->values[1]);
		elm_object_text_set(ad->txt_gyroy, tmp_txt);

		sprintf(tmp_txt, "<font_size=15>Gyro:[Z] %.3f</font>", event->values[2]);
		elm_object_text_set(ad->txt_gyroz, tmp_txt);

	}

}

static void bt_start_cb(appdata_s *ad, Evas_Object *obj, void *event_info) {
	if(isRunning == true) {
		isRunning = false;
		sensor_listener_stop(gListenerAccel);
		sensor_listener_stop(gyroListenerAccel);
		elm_object_text_set(ad->txt_msg, "<font_size=15>Paused</font>");
		elm_object_text_set(ad->bt_start, "<font_size=15>Start</font>");
	} else {
		isRunning = true;
		sensor_listener_start(gListenerAccel);
		sensor_listener_start(gyroListenerAccel);
		elm_object_text_set(ad->txt_msg, "<font_size=15>Running...</font>");
		elm_object_text_set(ad->bt_start, "<font_size=15>Pause</font>");
	}
}

static void bt_save_cb(appdata_s *ad, Evas_Object *obj, void *event_info) {
	char tmp_txt[100];
	char buffer[255];
	char DOCUMENTS_PATH[] = "/opt/usr/media/Documents/";

	int month, day, hour, minute, second;
	i18n_udate udate;
	sensor_listener_stop(gListenerAccel);
	sensor_listener_stop(gyroListenerAccel);
	isRunning = false;
	elm_object_text_set(ad->bt_start, "<font_size=15>Start</font>");
	system_settings_get_value_string(SYSTEM_SETTINGS_KEY_LOCALE_TIMEZONE, &ad->tzid);

	i18n_uchar *_tzid = (i18n_uchar*)calloc(strlen(ad->tzid) + 1, sizeof(i18n_uchar));

	i18n_ustring_copy_ua(_tzid, ad->tzid);

	int len = i18n_ustring_get_length(_tzid);

	i18n_ucalendar_create(_tzid, len, "en_US", I18N_UCALENDAR_TRADITIONAL, &ad->ucal);

	i18n_ucalendar_get_now(&udate);
	i18n_ucalendar_set_milliseconds(ad->ucal, udate);
	i18n_ucalendar_get(ad->ucal, I18N_UCALENDAR_MONTH, &month);
	i18n_ucalendar_get(ad->ucal, I18N_UCALENDAR_DATE, &day);
	i18n_ucalendar_get(ad->ucal, I18N_UCALENDAR_HOUR_OF_DAY, &hour);
	i18n_ucalendar_get(ad->ucal, I18N_UCALENDAR_MINUTE, &minute);
	i18n_ucalendar_get(ad->ucal, I18N_UCALENDAR_SECOND, &second);

	fileCount = fileCount + 1;
	sprintf(tmp_txt, "%stest_accel_%02d%02d_%02d%02d%02d.csv",DOCUMENTS_PATH, month+1,day,hour,minute,second);
	FILE *fp = fopen(tmp_txt, "w");
	for(int i = 1; i < gAccelCount; i++ ) {
		fprintf(fp, "%llu,%f,%f,%f,\n",
				gAccelTimeArray[i],
				gAccelValueArray[i][0],
				gAccelValueArray[i][1],
				gAccelValueArray[i][2]);
	}
	fclose(fp);

	sprintf(tmp_txt, "%stest_gyro_%02d%02d_%02d%02d%02d.csv",DOCUMENTS_PATH, month+1,day,hour,minute,second);
	FILE *fpGyro = fopen(tmp_txt, "w");
	for(int i = 1; i < gyroAccelCount; i++ ) {
		fprintf(fpGyro, "%llu,%f,%f,%f,\n",
				gyroAccelTimeArray[i],
				gyroAccelValueArray[i][0],
				gyroAccelValueArray[i][1],
				gyroAccelValueArray[i][2]);
	}
	fclose(fpGyro);

	sprintf(tmp_txt, "<font_size=15>Saved:(%d, %d, %d)</font>", fileCount, gAccelCount, gyroAccelCount);
	elm_object_text_set(ad->txt_msg, tmp_txt);
	dlog_print(DLOG_INFO, LOG_TAG, tmp_txt);
	gAccelCount = 0;
	gyroAccelCount = 0;
}

static void bt_exit_cb(appdata_s *ad, Evas_Object *obj, void *event_info) {
	ui_app_exit();
}



static void
win_delete_request_cb(void *data, Evas_Object *obj, void *event_info)
{
	ui_app_exit();
}

static void
win_back_cb(void *data, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = data;
	/* Let window go to hide state. */
	elm_win_lower(ad->win);
}

static void
create_base_gui(appdata_s *ad)
{
	/* Window */
	/* Create and initialize elm_win.
	   elm_win is mandatory to manipulate window. */
	ad->win = elm_win_util_standard_add(PACKAGE, PACKAGE);
	elm_win_autodel_set(ad->win, EINA_TRUE);

	if (elm_win_wm_rotation_supported_get(ad->win)) {
		int rots[4] = { 0, 90, 180, 270 };
		elm_win_wm_rotation_available_rotations_set(ad->win, (const int *)(&rots), 4);
	}

	evas_object_smart_callback_add(ad->win, "delete,request", win_delete_request_cb, NULL);
	eext_object_event_callback_add(ad->win, EEXT_CALLBACK_BACK, win_back_cb, ad);

	/* Conformant */
	/* Create and initialize elm_conformant.
	   elm_conformant is mandatory for base gui to have proper size
	   when indicator or virtual keypad is visible. */
	ad->conform = elm_conformant_add(ad->win);
	elm_win_indicator_mode_set(ad->win, ELM_WIN_INDICATOR_SHOW);
	elm_win_indicator_opacity_set(ad->win, ELM_WIN_INDICATOR_OPAQUE);
	evas_object_size_hint_weight_set(ad->conform, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_win_resize_object_add(ad->win, ad->conform);
	evas_object_show(ad->conform);

	/* Grid and objects */
	ad->grid = elm_grid_add(ad->conform);
	evas_object_size_hint_weight_set(ad->grid, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_grid_size_set(ad->grid, 16, 16);
	elm_object_content_set(ad->conform, ad->grid);

	ad->txt_senx = elm_label_add(ad->grid);
	elm_object_text_set(ad->txt_senx, "<font_size=15>Accel[x]: float</font>");
	evas_object_size_hint_weight_set(ad->txt_senx, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(ad->txt_senx,  EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_grid_pack(ad->grid, ad->txt_senx, 3, 3, 12, 1);
	evas_object_show(ad->txt_senx);

	ad->txt_seny = elm_label_add(ad->grid);
	elm_object_text_set(ad->txt_seny, "<font_size=15>Accel[y]: float</font>");
	evas_object_size_hint_weight_set(ad->txt_seny, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(ad->txt_seny,  EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_grid_pack(ad->grid, ad->txt_seny, 3, 4, 12, 1);
	evas_object_show(ad->txt_seny);

	ad->txt_senz = elm_label_add(ad->grid);
	elm_object_text_set(ad->txt_senz, "<font_size=15>Accel[z]: float</font>");
	evas_object_size_hint_weight_set(ad->txt_senz, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(ad->txt_senz,  EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_grid_pack(ad->grid, ad->txt_senz, 3, 5, 12, 1);
	evas_object_show(ad->txt_senz);

	ad->txt_gyrox = elm_label_add(ad->grid);
	elm_object_text_set(ad->txt_gyrox, "<font_size=15>Gyro[x]: float</font>");
	evas_object_size_hint_weight_set(ad->txt_gyrox, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(ad->txt_gyrox,  EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_grid_pack(ad->grid, ad->txt_gyrox, 8, 3, 12, 1);
	evas_object_show(ad->txt_gyrox);

	ad->txt_gyroy = elm_label_add(ad->grid);
	elm_object_text_set(ad->txt_gyroy, "<font_size=15>Gyro[y]: float</font>");
	evas_object_size_hint_weight_set(ad->txt_gyroy, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(ad->txt_gyroy,  EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_grid_pack(ad->grid, ad->txt_gyroy, 8, 4, 12, 1);
	evas_object_show(ad->txt_gyroy);

	ad->txt_gyroz = elm_label_add(ad->grid);
	elm_object_text_set(ad->txt_gyroz, "<font_size=15>Gyro[z]: float</font>");
	evas_object_size_hint_weight_set(ad->txt_gyroz, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(ad->txt_gyroz,  EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_grid_pack(ad->grid, ad->txt_gyroz, 8, 5, 12, 1);
	evas_object_show(ad->txt_gyroz);

	ad->txt_freq = elm_label_add(ad->grid);
	elm_object_text_set(ad->txt_freq, "<font_size=15>Freq: float</font>");
	evas_object_size_hint_weight_set(ad->txt_freq, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(ad->txt_freq,  EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_grid_pack(ad->grid, ad->txt_freq, 3, 6, 12, 1);
	evas_object_show(ad->txt_freq);

	ad->txt_msg = elm_label_add(ad->grid);
	elm_object_text_set(ad->txt_msg, "<font_size=15></font>");
	evas_object_size_hint_weight_set(ad->txt_msg, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(ad->txt_msg,  EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_grid_pack(ad->grid, ad->txt_msg, 3, 7, 12, 1);
	evas_object_show(ad->txt_msg);

	ad->bt_start = elm_button_add(ad->grid);
	elm_object_text_set(ad->bt_start, "<font_size=15>Start</font>");
	evas_object_size_hint_weight_set(ad->bt_start, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(ad->bt_start, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_grid_pack(ad->grid, ad->bt_start, 1, 10, 4, 1);
	evas_object_smart_callback_add(ad->bt_start, "clicked", bt_start_cb, ad);
	evas_object_show(ad->bt_start);

	ad->bt_save = elm_button_add(ad->grid);
	elm_object_text_set(ad->bt_save, "<font_size=15>Save</font>");
	evas_object_size_hint_weight_set(ad->bt_save, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(ad->bt_save, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_grid_pack(ad->grid, ad->bt_save, 6, 10, 4, 1);
	evas_object_smart_callback_add(ad->bt_save, "clicked", bt_save_cb, ad);
	evas_object_show(ad->bt_save);

	ad->bt_exit = elm_button_add(ad->grid);
	elm_object_text_set(ad->bt_exit, "<font_size=15>Exit</font>");
	evas_object_size_hint_weight_set(ad->bt_exit, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(ad->bt_exit, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_grid_pack(ad->grid, ad->bt_exit, 11, 10, 4, 1);
	evas_object_smart_callback_add(ad->bt_exit, "clicked", bt_exit_cb, ad);
	evas_object_show(ad->bt_exit);

	/* Show window after base gui is set up */
	evas_object_show(ad->win);
}

static bool
app_create(void *data)
{
	/* Hook to take necessary actions before main event loop starts
		Initialize UI resources and application's data
		If this function returns true, the main loop of application starts
		If this function returns false, the application is terminated */
	appdata_s *ad = data;

	create_base_gui(ad);

	//Create sensor listener
	/* get the default sensor of heart rate monitor */
	bool Accelsupported = false;
	bool Gyrosupported = false;
	sensor_is_supported(SENSOR_ACCELEROMETER, &Accelsupported);
	sensor_is_supported(SENSOR_GYROSCOPE, &Gyrosupported);
	if(Accelsupported) {
		gSensorSupported[0] = true;
		sensor_get_default_sensor(SENSOR_ACCELEROMETER, &gSensorAccel);
		sensor_create_listener(gSensorAccel, &gListenerAccel);
		sensor_listener_set_event_cb(gListenerAccel, 10, example_sensor_callback, ad);	//Change the interval for modifying sampling frequency
		//sensor_listener_start(gListenerAccel);
	} else {
		gSensorSupported[0] = false;
		elm_object_text_set(ad->txt_senx, "<font_size=15>Accel: not supported</font>");
	}

	if(Gyrosupported) {
		gyroSensorSupported[0] = true;
		sensor_get_default_sensor(SENSOR_GYROSCOPE, &gyroSensorAccel);
		sensor_create_listener(gyroSensorAccel, &gyroListenerAccel);
		sensor_listener_set_event_cb(gyroListenerAccel, 10, example_sensor_callback, ad);	//Change the interval for modifying sampling frequency
		//sensor_listener_start(gyroListenerAccel);
	} else {
		gyroSensorSupported[0] = false;
		elm_object_text_set(ad->txt_gyrox, "<font_size=15>Gyro: not supported</font>");
	}


	return true;
}

static void
app_control(app_control_h app_control, void *data)
{
	/* Handle the launch request. */
}

static void
app_pause(void *data)
{
	/* Take necessary actions when application becomes invisible. */
}

static void
app_resume(void *data)
{
	/* Take necessary actions when application becomes visible. */
}

static void
app_terminate(void *data)
{
	/* Release all resources. */
	if(gSensorSupported[0] == true) {
		sensor_listener_stop(gListenerAccel);
		sensor_destroy_listener(gListenerAccel);
	}
}

static void
ui_app_lang_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LANGUAGE_CHANGED*/
	char *locale = NULL;
	system_settings_get_value_string(SYSTEM_SETTINGS_KEY_LOCALE_LANGUAGE, &locale);
	elm_language_set(locale);
	free(locale);
	return;
}

static void
ui_app_orient_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_DEVICE_ORIENTATION_CHANGED*/
	return;
}

static void
ui_app_region_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_REGION_FORMAT_CHANGED*/
}

static void
ui_app_low_battery(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LOW_BATTERY*/
}

static void
ui_app_low_memory(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LOW_MEMORY*/
}

int
main(int argc, char *argv[])
{
	appdata_s ad = {0,};
	int ret = 0;

	ui_app_lifecycle_callback_s event_callback = {0,};
	app_event_handler_h handlers[5] = {NULL, };

	event_callback.create = app_create;
	event_callback.terminate = app_terminate;
	event_callback.pause = app_pause;
	event_callback.resume = app_resume;
	event_callback.app_control = app_control;

	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_BATTERY], APP_EVENT_LOW_BATTERY, ui_app_low_battery, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_MEMORY], APP_EVENT_LOW_MEMORY, ui_app_low_memory, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_DEVICE_ORIENTATION_CHANGED], APP_EVENT_DEVICE_ORIENTATION_CHANGED, ui_app_orient_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LANGUAGE_CHANGED], APP_EVENT_LANGUAGE_CHANGED, ui_app_lang_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_REGION_FORMAT_CHANGED], APP_EVENT_REGION_FORMAT_CHANGED, ui_app_region_changed, &ad);

	ret = ui_app_main(argc, argv, &event_callback, &ad);
	if (ret != APP_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "app_main() is failed. err = %d", ret);
	}

	return ret;
}
