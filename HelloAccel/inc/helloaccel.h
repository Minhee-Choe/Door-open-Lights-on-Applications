#ifndef __helloaccel_H__
#define __helloaccel_H__

#include <app.h>
#include <Elementary.h>
#include <system_settings.h>
#include <efl_extension.h>
#include <dlog.h>
#include <sensor.h>
#include <storage.h>
#include <utils_i18n.h>

#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "helloaccel"

#if !defined(PACKAGE)
#define PACKAGE "org.example.helloaccel"
#endif

#define BIG_NUMBER 100000
#define FREQUENCY_SAMPLES 50

typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *grid;
	Evas_Object *txt_senx;
	Evas_Object *txt_seny;
	Evas_Object *txt_senz;
	Evas_Object *txt_gyrox;
	Evas_Object *txt_gyroy;
	Evas_Object *txt_gyroz;
	Evas_Object *txt_freq;
	Evas_Object *txt_msg;
	Evas_Object *bt_start;
	Evas_Object *bt_save;
	Evas_Object *bt_exit;
	i18n_ucalendar_h ucal;
	char *tzid;
} appdata_s;

void
example_sensor_callback(sensor_h sensor, sensor_event_s *event, appdata_s *ad);

static void
bt_start_cb(appdata_s *ad, Evas_Object *obj, void *event_info);

static void
bt_save_cb(appdata_s *ad, Evas_Object *obj, void *event_info);

static void
bt_exit_cb(appdata_s *ad, Evas_Object *obj, void *event_info);

#endif /* __helloaccel_H__ */
