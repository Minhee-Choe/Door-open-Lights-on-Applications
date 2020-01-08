S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.2.1
Build-Number: R720XXU2EPK5
Build-Date: 2016.11.25 12:47:41

Crash Information
Process Name: helloaccel
PID: 4445
Date: 2017-04-06 02:03:39+0900
Executable File Path: /opt/usr/apps/org.example.helloaccel/bin/helloaccel
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 4445, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x80000000, r3   = 0x00000000
r4   = 0x0000001a, r5   = 0x418b4c12
r6   = 0x417c1df8, r7   = 0xbec46210
r8   = 0x00000000, r9   = 0x418363b0
r10  = 0x418415a8, fp   = 0x00000001
ip   = 0x404f30b0, sp   = 0xbec45fa8
lr   = 0x418b44cb, pc   = 0x404f30b4
cpsr = 0x60000010

Memory Information
MemTotal:   490112 KB
MemFree:      6064 KB
Buffers:     21308 KB
Cached:     102916 KB
VmPeak:     106964 KB
VmSize:     104928 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       18948 KB
VmRSS:       18948 KB
VmData:      42332 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25576 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 4445 TID = 4445
4445 4547 4548 4549 4552 

Maps Information
40000000 40005000 r-xp /usr/bin/launchpad-loader
4000d000 4002a000 r-xp /lib/ld-2.13.so
40033000 40037000 r-xp /usr/lib/libsys-assert.so
40041000 40047000 r-xp /usr/lib/libappcore-efl.so.1.1
40056000 40063000 r-xp /usr/lib/libaul.so.0.1.0
4006d000 4006f000 r-xp /lib/libdl-2.13.so
40078000 4007b000 r-xp /usr/lib/libbundle.so.0.1.22
40083000 40085000 r-xp /usr/lib/libdlog.so.0.0.0
4008d000 400a1000 r-xp /lib/libpthread-2.13.so
400ac000 401e8000 r-xp /usr/lib/libelementary.so.1.7.99
401ff000 402cd000 r-xp /usr/lib/libevas.so.1.7.99
402f2000 40309000 r-xp /usr/lib/libecore.so.1.7.99
40320000 4037e000 r-xp /usr/lib/libedje.so.1.7.99
40388000 40458000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
40459000 4045f000 r-xp /usr/lib/libprivilege-control.so.0.0.2
40467000 4046b000 r-xp /usr/lib/libsmack.so.1.0.0
40474000 4047c000 r-xp /lib/libgcc_s-4.6.so.1
4047d000 405a1000 r-xp /lib/libc-2.13.so
405af000 405cd000 r-xp /usr/lib/libsystemd.so.0.4.0
405d7000 405e2000 r-xp /lib/libunwind.so.8.0.1
4060f000 40626000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
4062e000 40658000 r-xp /usr/lib/libdbus-1.so.3.8.12
40661000 40666000 r-xp /usr/lib/libxdgmime.so.1.1.0
4066e000 40691000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
40699000 4069a000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
406a2000 406a8000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
406b1000 4071a000 r-xp /lib/libm-2.13.so
40723000 4073c000 r-xp /usr/lib/libeet.so.1.7.99
4074d000 4078e000 r-xp /usr/lib/libeina.so.1.7.99
40797000 407b9000 r-xp /usr/lib/libecore_evas.so.1.7.99
407c2000 407c7000 r-xp /usr/lib/libecore_file.so.1.7.99
407cf000 407e0000 r-xp /usr/lib/libecore_input.so.1.7.99
407e8000 407f1000 r-xp /usr/lib/libvconf.so.0.2.45
407f9000 40849000 r-xp /usr/lib/libecore_x.so.1.7.99
4084b000 40854000 r-xp /usr/lib/libedbus.so.1.7.99
4085c000 40876000 r-xp /usr/lib/libecore_con.so.1.7.99
4087f000 40892000 r-xp /usr/lib/libfribidi.so.0.3.1
4089a000 408df000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
408e8000 40910000 r-xp /usr/lib/libfontconfig.so.1.8.0
40911000 40967000 r-xp /usr/lib/libfreetype.so.6.11.3
40973000 409c9000 r-xp /usr/lib/libpixman-1.so.0.28.2
409d6000 409dc000 r-xp /lib/librt-2.13.so
409e5000 409ec000 r-xp /usr/lib/libembryo.so.1.7.99
409f4000 40a0b000 r-xp /usr/lib/liblua-5.1.so
40a14000 40a1a000 r-xp /usr/lib/libecore_imf.so.1.7.99
40a22000 40a23000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
40a2b000 40a5a000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
40a62000 40a65000 r-xp /lib/libcap.so.2.21
40a6d000 40a85000 r-xp /usr/lib/liblzma.so.5.0.3
40a8d000 40a9d000 r-xp /lib/libresolv-2.13.so
40aa1000 40b74000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
40b7f000 40bb3000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
40bbc000 40bd6000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40bde000 40c53000 r-xp /usr/lib/libsqlite3.so.0.8.6
40c5d000 40c5f000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
40c67000 40c7d000 r-xp /lib/libz.so.1.2.5
40c85000 40ca8000 r-xp /usr/lib/libjpeg.so.8.0.2
40cc0000 40da1000 r-xp /usr/lib/libX11.so.6.3.0
40dac000 40db1000 r-xp /usr/lib/libecore_fb.so.1.7.99
40dba000 40dbe000 r-xp /usr/lib/libecore_ipc.so.1.7.99
40dc7000 40dca000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
40dd2000 40dd9000 r-xp /usr/lib/libXcursor.so.1.0.2
40de1000 40de3000 r-xp /usr/lib/libXdamage.so.1.1.0
40deb000 40ded000 r-xp /usr/lib/libXcomposite.so.1.0.0
40df5000 40df7000 r-xp /usr/lib/libXgesture.so.7.0.0
40dff000 40e02000 r-xp /usr/lib/libXfixes.so.3.1.0
40e0a000 40e13000 r-xp /usr/lib/libXi.so.6.1.0
40e1b000 40e1c000 r-xp /usr/lib/libXinerama.so.1.0.0
40e25000 40e2b000 r-xp /usr/lib/libXrandr.so.2.2.0
40e33000 40e39000 r-xp /usr/lib/libXrender.so.1.3.0
40e41000 40e45000 r-xp /usr/lib/libXtst.so.6.1.0
40e4d000 40e57000 r-xp /usr/lib/libXext.so.6.4.0
40e60000 40ea4000 r-xp /usr/lib/libcurl.so.4.3.0
40ead000 40ec3000 r-xp /lib/libexpat.so.1.6.0
40ecd000 40ee5000 r-xp /usr/lib/libpng12.so.0.50.0
40eed000 40f0a000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
40f13000 40fa7000 r-xp /usr/lib/libstdc++.so.6.0.16
40fba000 40fbd000 r-xp /lib/libattr.so.1.1.0
40fc5000 40fc6000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
40fce000 40fd3000 r-xp /usr/lib/libffi.so.5.0.10
40fdc000 40fde000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
40fe6000 410b2000 r-xp /usr/lib/libxml2.so.2.7.8
410bf000 410c1000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
410ca000 410cc000 r-xp /usr/lib/journal/libjournal.so.0.1.0
410d4000 410e7000 r-xp /usr/lib/libxcb.so.1.1.0
410f1000 410fa000 r-xp /usr/lib/libcares.so.2.1.0
41103000 41131000 r-xp /usr/lib/libidn.so.11.5.44
41139000 41180000 r-xp /usr/lib/libssl.so.1.0.0
4118c000 4131e000 r-xp /usr/lib/libcrypto.so.1.0.0
41340000 41342000 r-xp /usr/lib/libiri.so
4134a000 41351000 r-xp /lib/libcrypt-2.13.so
41381000 41383000 r-xp /usr/lib/libXau.so.6.0.0
41490000 41494000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4149c000 414a4000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
414a6000 414ab000 r-xp /usr/lib/libappcore-common.so.1.1
414b3000 414b5000 r-xp /usr/lib/libiniparser.so.0
414be000 414c9000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
414d4000 414d8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
414e1000 414e3000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
414ec000 414f2000 r-xp /usr/lib/libappsvc.so.0.1.0
414fa000 4151e000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
41527000 415f6000 r-xp /usr/lib/libscim-1.0.so.8.2.3
4160c000 41616000 r-xp /lib/libnss_files-2.13.so
418b2000 418b5000 r-xp /opt/usr/apps/org.example.helloaccel/bin/helloaccel
41c96000 41cc3000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.2
41ccc000 41cd8000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
41ce1000 41d02000 r-xp /usr/lib/libefl-extension.so.0.1.0
41d0a000 41e92000 r-xp /usr/lib/libicui18n.so.57.1
41ea2000 41fa8000 r-xp /usr/lib/libicuuc.so.57.1
41fbe000 41fe8000 r-xp /usr/lib/libsensor.so.1.9.5
41ff1000 41ff8000 r-xp /usr/lib/libctx-shared.so.0.8.3
42000000 42005000 r-xp /usr/lib/libctx-client.so.0.8.3
4200d000 4201f000 r-xp /usr/lib/libefl-assist.so.0.1.0
42027000 420df000 r-xp /usr/lib/libcairo.so.2.11200.14
4397b000 43985000 r-xp /usr/lib/libsensord-shared.so
4398d000 4399c000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
439a5000 439bb000 r-xp /usr/lib/libtts.so
439c4000 439e7000 r-xp /usr/lib/libui-extension.so.0.1.0
439f0000 439fb000 r-xp /usr/lib/libtbm.so.1.0.0
43a03000 43a11000 r-xp /usr/lib/libGLESv2.so.2.0
43a1a000 43a1b000 r-xp /usr/lib/libxcb-shm.so.0.0.0
43a24000 43a2a000 r-xp /usr/lib/libxcb-render.so.0.0.0
43a32000 43a35000 r-xp /usr/lib/libEGL.so.1.4
43a3d000 43a42000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
43a4a000 43a4d000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
43a55000 43a56000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
43a5f000 43a67000 r-xp /usr/lib/libdrm.so.2.4.0
43a6f000 43a71000 r-xp /usr/lib/libdri2.so.0.0.0
43a79000 43a7f000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
43a87000 43a8c000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
43a94000 43aad000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
43ab5000 43ad6000 r-xp /usr/lib/libexif.so.12.3.3
43ae9000 43aeb000 r-xp /usr/lib/libttrace.so.1.1
43af3000 43af8000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
43b00000 43b06000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
43b0f000 43b17000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
43b1f000 43b41000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
43b4a000 43b51000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
43b5a000 43b5c000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
43b64000 43b6b000 r-xp /usr/lib/libminizip.so.1.0.0
43b73000 43b80000 r-xp /usr/lib/libail.so.0.1.0
43b89000 43b8f000 r-xp /usr/lib/libproc-stat.so.0.2.96
43b97000 43b98000 r-xp /usr/lib/libresponse.so.0.2.96
43ba0000 43ba5000 r-xp /usr/lib/libsystem.so.0.0.0
43baf000 43c79000 r-xp /usr/lib/libCOREGL.so.4.0
43fbc000 43fc7000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43fd0000 43fd5000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43fdd000 43ff4000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
440c4000 448c3000 rw-p [stack:4547]
448c4000 450c3000 rw-p [stack:4548]
450c4000 458c3000 rw-p [stack:4549]
458c3000 458c6000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
458ce000 458cf000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
458d7000 458d8000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
458f6000 458fe000 r-xp /usr/lib/libfeedback.so.0.1.4
45a01000 46200000 rw-p [stack:4552]
4627f000 46280000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
46288000 4628a000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
46292000 4629d000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
462a5000 462ac000 r-xp /usr/lib/libmmfcommon.so.0.0.0
462b4000 462cc000 r-xp /usr/lib/libmmfsound.so.0.1.0
462dd000 462e1000 r-xp /usr/lib/libmmfsession.so.0.0.0
462ea000 462f5000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
46302000 46306000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
4630e000 46324000 r-xp /usr/lib/libavsysaudio.so.0.0.1
4632c000 4638d000 r-xp /usr/lib/libasound.so.2.0.0
46397000 4639a000 r-xp /usr/lib/libpulse-simple.so.0.0.4
463a2000 463da000 r-xp /usr/lib/libpulse.so.0.16.2
463db000 463de000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
463e6000 4642e000 r-xp /usr/lib/libmdm.so.1.2.62
4642f000 46432000 r-xp /usr/lib/libtinycompress.so.0.0.0
4643a000 4643f000 r-xp /usr/lib/libjson.so.0.0.1
46447000 46490000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
46499000 464e0000 r-xp /usr/lib/libsndfile.so.1.0.26
464ec000 464fb000 r-xp /usr/lib/libmdm-common.so.1.1.22
46504000 46526000 r-xp /usr/lib/libvorbis.so.0.4.3
4652e000 46532000 r-xp /usr/lib/libogg.so.0.7.1
bec26000 bec47000 rw-p [stack]
End of Maps Information

Callstack Information (PID:4445)
Call Stack Count: 1
 0: strlen + 0x4 (0x404f30b4) [/lib/libc.so.6] + 0x760b4
End of Call Stack

Package Information
Package Name: org.example.helloaccel
Package ID : org.example.helloaccel
Version: 1.0.0
Package Type: rpm
App Name: helloaccel
App ID: org.example.helloaccel
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
tor_moment_view.c: windicator_moment_view_battery_layout_show(937) > [windicator_moment_view_battery_layout_show:937] [CHARGING_UI][LCD_ON] windicator_moment_view_battery_layout_show
04-06 02:03:33.457+0900 W/W_INDICATOR(  781): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(276) > [wnidicator_moment_view_battery_image_update:276] [CHARGING_UI] ad->is_connected : 0 // ad->is_full : 4 // ad->is_charged : 0
04-06 02:03:33.457+0900 W/W_INDICATOR(  781): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(286) > [wnidicator_moment_view_battery_image_update:286] [CHARGING_UI] [HIDE charging icon] Not connected or Battery full (5)
04-06 02:03:33.462+0900 W/W_INDICATOR(  781): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(300) > [wnidicator_moment_view_battery_image_update:300] [CHARGING_UI] battery level 100, index 20, bg level 100
04-06 02:03:33.462+0900 W/W_INDICATOR(  781): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(368) > [wnidicator_moment_view_battery_image_update:368] [CHARGING_UI] strLevel : 100, 100
04-06 02:03:33.462+0900 W/W_INDICATOR(  781): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(377) > [wnidicator_moment_view_battery_image_update:377] [CHARGING_UI] Succeed to get icu str for battery_level, so set (100)
04-06 02:03:33.462+0900 W/W_INDICATOR(  781): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(387) > [wnidicator_moment_view_battery_image_update:387] [Normal] current_locale : ko_KR.UTF-8
04-06 02:03:33.927+0900 E/PKGMGR_SERVER( 4377): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=1, queue_status=1] 
04-06 02:03:33.927+0900 E/PKGMGR_SERVER( 4377): pkgmgr-server.c: main(2296) > package manager server terminated.
04-06 02:03:34.067+0900 E/WMS     (  513): wms_event_handler.c: _wms_event_handler_cb_nomove_detector(23534) > _wms_event_handler_cb_nomove_detector is called
04-06 02:03:34.067+0900 W/WATCH_CORE( 9906): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
04-06 02:03:34.067+0900 I/WATCH_CORE( 9906): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
04-06 02:03:34.067+0900 I/CAPI_WATCH_APPLICATION( 9906): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-06 02:03:34.067+0900 E/watchface-loader( 9906): watchface-loader.cpp: OnAppTimeTick(616) > 
04-06 02:03:34.067+0900 I/watchface-loader( 9906): watchface-loader.cpp: OnAppTimeTick(628) > set force update!!
04-06 02:03:34.072+0900 I/watchface-viewer( 9906): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(577) > ImagesLoadingDoneSignal().Emit()
04-06 02:03:34.102+0900 W/WATCH_CORE( 9906): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOff
04-06 02:03:34.112+0900 W/W_HOME  (  837): dbus.c: _dbus_message_recv_cb(204) > LCD off
04-06 02:03:34.112+0900 W/W_HOME  (  837): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
04-06 02:03:34.112+0900 W/W_HOME  (  837): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-06 02:03:34.112+0900 W/W_HOME  (  837): gesture.c: _manual_render_enable(138) > 1
04-06 02:03:34.112+0900 W/W_HOME  (  837): event_manager.c: _lcd_off_cb(729) > lcd state: 0
04-06 02:03:34.112+0900 W/W_HOME  (  837): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-06 02:03:34.117+0900 W/STARTER (  780): clock-mgr.c: _on_lcd_signal_receive_cb(1605) > [_on_lcd_signal_receive_cb:1605] _on_lcd_signal_receive_cb, 1605, Pre LCD off by [gesture]
04-06 02:03:34.117+0900 W/STARTER (  780): clock-mgr.c: _pre_lcd_off(1378) > [_pre_lcd_off:1378] Will LCD OFF as wake_up_setting[1]
04-06 02:03:34.117+0900 E/STARTER (  780): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
04-06 02:03:34.117+0900 W/STARTER (  780): clock-mgr.c: _check_reserved_popup_status(200) > [_check_reserved_popup_status:200] Current reserved apps status : 0
04-06 02:03:34.117+0900 W/STARTER (  780): clock-mgr.c: _check_reserved_apps_status(236) > [_check_reserved_apps_status:236] Current reserved apps status : 0
04-06 02:03:34.132+0900 W/WAKEUP-SERVICE( 1292): WakeupService.cpp: OnReceiveDisplayChanged(979) > [0;32mINFO: LCDOff receive data : 1075006220[0;m
04-06 02:03:34.132+0900 W/WAKEUP-SERVICE( 1292): WakeupService.cpp: OnReceiveDisplayChanged(980) > [0;32mINFO: WakeupServiceStop[0;m
04-06 02:03:34.132+0900 W/WAKEUP-SERVICE( 1292): WakeupService.cpp: WakeupServiceStop(399) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
04-06 02:03:34.132+0900 E/WAKEUP-SERVICE( 1292): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-06 02:03:34.132+0900 E/WAKEUP-SERVICE( 1292): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-06 02:03:34.132+0900 I/TIZEN_N_SOUND_MANAGER( 1292): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Disable start
04-06 02:03:34.142+0900 I/TIZEN_N_SOUND_MANAGER( 1292): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Disable end. (ret: 0x0)
04-06 02:03:34.142+0900 W/TIZEN_N_SOUND_MANAGER( 1292): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-06 02:03:34.142+0900 W/WAKEUP-SERVICE( 1292): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 0[0;m
04-06 02:03:34.142+0900 I/HIGEAR  ( 1292): WakeupService.cpp: WakeupServiceStop(403) > [svoice:Application:WakeupServiceStop:IN]
04-06 02:03:34.232+0900 W/W_INDICATOR(  781): windicator_moment_view.c: windicator_moment_view_fade_in_battery_layout(955) > [windicator_moment_view_fade_in_battery_layout:955] [CHARGING_UI][Rotation status] windicator_moment_view_fade_in_battery_layout
04-06 02:03:34.232+0900 E/W_INDICATOR(  781): windicator_moment_view.c: windicator_moment_view_fade_in_battery_layout(958) > [windicator_moment_view_fade_in_battery_layout:958] [CHARGING_UI][Rotation status] Battery layout is already shown by rotation callback
04-06 02:03:34.262+0900 W/W_INDICATOR(  781): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1504) > [windicator_hide_moment_bar_directly:1504] windicator_hide_moment_bar_directly
04-06 02:03:34.262+0900 W/SHealthCommon( 1012): SystemUtil.cpp: OnDeviceStatusChanged(1041) > [1;35mlcdState:3[0;m
04-06 02:03:34.262+0900 I/watchface-viewer( 9906): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[2] sDisplayStateNormal[0]
04-06 02:03:34.277+0900 W/STARTER (  780): clock-mgr.c: _on_lcd_signal_receive_cb(1618) > [_on_lcd_signal_receive_cb:1618] _on_lcd_signal_receive_cb, 1618, Post LCD off by [gesture]
04-06 02:03:34.277+0900 W/W_INDICATOR(  781): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
04-06 02:03:34.277+0900 W/STARTER (  780): clock-mgr.c: _post_lcd_off(1510) > [_post_lcd_off:1510] LCD OFF as reserved app[(null)] alpm mode[0]
04-06 02:03:34.277+0900 W/STARTER (  780): clock-mgr.c: _post_lcd_off(1517) > [_post_lcd_off:1517] Current reserved apps status : 0
04-06 02:03:34.277+0900 W/STARTER (  780): clock-mgr.c: _post_lcd_off(1535) > [_post_lcd_off:1535] raise homescreen after 20 sec. home_visible[0]
04-06 02:03:34.277+0900 E/ALARM_MANAGER(  780): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(20), start(6-4-2017, 02:03:54), repeat(1), interval(20), type(-1073741822)
04-06 02:03:34.277+0900 W/W_INDICATOR(  781): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
04-06 02:03:34.277+0900 W/W_INDICATOR(  781): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1504) > [windicator_hide_moment_bar_directly:1504] windicator_hide_moment_bar_directly
04-06 02:03:34.282+0900 I/APP_CORE( 4445): appcore-efl.c: __do_app(453) > [APP 4445] Event: PAUSE State: RUNNING
04-06 02:03:34.282+0900 I/CAPI_APPFW_APPLICATION( 4445): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
04-06 02:03:34.282+0900 W/APP_CORE( 4445): appcore-efl.c: _capture_and_make_file(1721) > Capture : win[3800002] -> redirected win[601675] for org.example.helloaccel[4445]
04-06 02:03:34.282+0900 E/ALARM_MANAGER(  505): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [780].
04-06 02:03:34.332+0900 E/ALARM_MANAGER(  505): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 1513140448, next duetime: 1491411834
04-06 02:03:34.332+0900 E/ALARM_MANAGER(  505): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(1513140448)
04-06 02:03:34.332+0900 E/ALARM_MANAGER(  505): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1491412428), due_time(1491411834)
04-06 02:03:34.337+0900 I/APP_CORE(  781): appcore-efl.c: __do_app(453) > [APP 781] Event: PAUSE State: RUNNING
04-06 02:03:34.337+0900 I/CAPI_APPFW_APPLICATION(  781): app_main.c: app_appcore_pause(202) > app_appcore_pause
04-06 02:03:34.337+0900 E/ALARM_MANAGER(  505): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
04-06 02:03:34.342+0900 E/ALARM_MANAGER(  505): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-06 02:03:34.342+0900 E/ALARM_MANAGER(  505): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 5-4-2017, 17:03:54 (UTC).
04-06 02:03:34.342+0900 E/ALARM_MANAGER(  505): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-06 02:03:34.342+0900 W/SHealthCommon( 1233): SystemUtil.cpp: OnDeviceStatusChanged(1041) > [1;35mlcdState:3[0;m
04-06 02:03:34.342+0900 E/ALARM_MANAGER(  505): alarm-manager.c: __save_module_log(1778) > The file is not ready.
04-06 02:03:34.342+0900 W/SHealthService( 1233): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
04-06 02:03:34.347+0900 E/ALARM_MANAGER(  505): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
04-06 02:03:34.347+0900 E/ALARM_MANAGER(  505): alarm-manager.c: __save_module_log(1778) > The file is not ready.
04-06 02:03:34.887+0900 I/MALI    ( 4447): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(756) > [EGL-X11] surface has been resized, clean up all the render target [1x1] -> [360x360]
04-06 02:03:34.892+0900 E/MALI    ( 4447): egl_mali.c: __egl_mali_post_to_window_surface(1183) > MALI_ERR_EARLY_OUT - Don't need to add frame callback because frame is unmodified
04-06 02:03:34.917+0900 I/AUL     ( 4558): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/WebProcess, ret : 0
04-06 02:03:34.932+0900 I/AUL     ( 4558): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
04-06 02:03:34.932+0900 E/AUL     ( 4558): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
04-06 02:03:34.932+0900 E/AUL     ( 4558): aul_path.c: __get_path(169) > root_path is NULL!
04-06 02:03:35.052+0900 W/WATCH_CORE( 9906): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
04-06 02:03:35.052+0900 I/WATCH_CORE( 9906): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
04-06 02:03:35.052+0900 I/CAPI_WATCH_APPLICATION( 9906): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-06 02:03:35.052+0900 E/watchface-loader( 9906): watchface-loader.cpp: OnAppTimeTick(616) > 
04-06 02:03:35.052+0900 I/watchface-loader( 9906): watchface-loader.cpp: OnAppTimeTick(628) > set force update!!
04-06 02:03:35.052+0900 I/watchface-viewer( 9906): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(577) > ImagesLoadingDoneSignal().Emit()
04-06 02:03:35.057+0900 W/W_HOME  (  837): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
04-06 02:03:35.057+0900 W/W_HOME  (  837): gesture.c: _manual_render_schedule(209) > schedule, manual render
04-06 02:03:35.082+0900 W/WATCH_CORE( 9906): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOn
04-06 02:03:35.082+0900 I/WATCH_CORE( 9906): appcore-watch.c: __signal_lcd_status_handler(1250) > Call the time_tick_cb
04-06 02:03:35.082+0900 I/CAPI_WATCH_APPLICATION( 9906): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-06 02:03:35.082+0900 E/watchface-loader( 9906): watchface-loader.cpp: OnAppTimeTick(616) > 
04-06 02:03:35.082+0900 I/watchface-loader( 9906): watchface-loader.cpp: OnAppTimeTick(628) > set force update!!
04-06 02:03:35.082+0900 I/WATCH_CORE( 9906): appcore-watch.c: __signal_lcd_status_handler(1257) > Call widget_provider_update_event
04-06 02:03:35.087+0900 W/W_HOME  (  837): gesture.c: _widget_updated_cb(188) > widget updated
04-06 02:03:35.087+0900 W/W_HOME  (  837): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-06 02:03:35.087+0900 W/W_HOME  (  837): gesture.c: _manual_render(182) > 
04-06 02:03:35.102+0900 W/WAKEUP-SERVICE( 1292): WakeupService.cpp: OnReceiveGestureChanged(995) > [0;32mINFO: wakeup receive data : 1127336696[0;m
04-06 02:03:35.102+0900 W/WAKEUP-SERVICE( 1292): WakeupService.cpp: OnReceiveGestureChanged(996) > [0;32mINFO: WakeupServiceStart[0;m
04-06 02:03:35.102+0900 W/WAKEUP-SERVICE( 1292): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
04-06 02:03:35.102+0900 I/TIZEN_N_SOUND_MANAGER( 1292): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
04-06 02:03:35.107+0900 W/wnotibp ( 7251): wnotiboard-popup-control.c: _ctrl_lcd_on_cb(91) > ::APP:: view state=0, 2, 0
04-06 02:03:35.107+0900 I/wnotibp ( 7251): wnotiboard-popup-control.c: _ctrl_lcd_on_cb(140) > There is no additional work.
04-06 02:03:35.127+0900 W/STARTER (  780): clock-mgr.c: _on_lcd_signal_receive_cb(1579) > [_on_lcd_signal_receive_cb:1579] _on_lcd_signal_receive_cb, 1579, Pre LCD on by [gesture] after screen off time [994]ms
04-06 02:03:35.127+0900 W/STARTER (  780): clock-mgr.c: _pre_lcd_on(1298) > [_pre_lcd_on:1298] Will LCD ON as reserved app[(null)] alpm mode[0]
04-06 02:03:35.142+0900 I/APP_CORE( 4445): appcore-efl.c: __do_app(453) > [APP 4445] Event: RESUME State: PAUSED
04-06 02:03:35.142+0900 I/CAPI_APPFW_APPLICATION( 4445): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
04-06 02:03:35.157+0900 W/SHealthCommon( 1012): SystemUtil.cpp: OnDeviceStatusChanged(1041) > [1;35mlcdState:1[0;m
04-06 02:03:35.167+0900 I/watchface-viewer( 9906): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[0] sDisplayStateNormal[1]
04-06 02:03:35.287+0900 E/ALARM_MANAGER(  505): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [780].
04-06 02:03:35.287+0900 E/ALARM_MANAGER(  505): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(1513140448)
04-06 02:03:35.302+0900 E/wnoti-service( 1083): wnoti-db-utility.c: context_wearonoff_status_cb(1753) > status changed from 2 to 1 
04-06 02:03:35.302+0900 E/wnoti-service( 1083): wnoti-native-client.c: handle_cache_notification(603) > >>
04-06 02:03:35.302+0900 E/WMS     (  513): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(23474) > wear_monitor_status update[0] = 2 -> 1
04-06 02:03:35.307+0900 W/WECONN  (  492): <__wc_feature_wearonoff_monitor_cb:511> { error=0, state=CONTEXT_WEARONOFF_MONITOR_STATUS_ON
04-06 02:03:35.307+0900 W/WECONN  (  492): <__wc_device_on_wear_onoff_changed_cb:354> { state=WC_FEATURE_STATE_ON
04-06 02:03:35.307+0900 W/WECONN  (  492): <__wc_device_on_wear_onoff_changed_cb:369> Disconnected manually : 0
04-06 02:03:35.307+0900 W/WECONN  (  492): <__wc_device_on_wear_onoff_changed_cb:370> Disconnected by auto switch : 0
04-06 02:03:35.307+0900 W/WECONN  (  492): <__wc_device_on_wear_onoff_changed_cb:385> }
04-06 02:03:35.307+0900 W/WECONN  (  492): <__wc_feature_wearonoff_monitor_cb:531> }
04-06 02:03:35.312+0900 W/WATCH_CORE( 9906): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
04-06 02:03:35.312+0900 I/WATCH_CORE( 9906): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
04-06 02:03:35.312+0900 I/CAPI_WATCH_APPLICATION( 9906): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-06 02:03:35.312+0900 E/watchface-loader( 9906): watchface-loader.cpp: OnAppTimeTick(616) > 
04-06 02:03:35.312+0900 I/watchface-loader( 9906): watchface-loader.cpp: OnAppTimeTick(628) > set force update!!
04-06 02:03:35.317+0900 E/ALARM_MANAGER(  505): alarm-manager.c: __display_lock_state(1882) > Lock LCD OFF is successfully done
04-06 02:03:35.322+0900 E/ALARM_MANAGER(  505): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-06 02:03:35.322+0900 E/ALARM_MANAGER(  505): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 5-4-2017, 17:13:48 (UTC).
04-06 02:03:35.322+0900 E/ALARM_MANAGER(  505): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-06 02:03:35.322+0900 E/ALARM_MANAGER(  505): alarm-manager.c: __save_module_log(1778) > The file is not ready.
04-06 02:03:35.347+0900 E/ALARM_MANAGER(  505): alarm-manager.c: __display_unlock_state(1925) > Unlock LCD OFF is successfully done
04-06 02:03:35.347+0900 E/ALARM_MANAGER(  505): alarm-manager.c: alarm_manager_alarm_delete(2460) > alarm_id[1513140448] is removed.
04-06 02:03:35.347+0900 E/ALARM_MANAGER(  505): alarm-manager.c: __save_module_log(1778) > The file is not ready.
04-06 02:03:35.352+0900 W/STARTER (  780): clock-mgr.c: _on_lcd_signal_receive_cb(1592) > [_on_lcd_signal_receive_cb:1592] _on_lcd_signal_receive_cb, 1592, Post LCD on by [gesture]
04-06 02:03:35.352+0900 W/STARTER (  780): clock-mgr.c: _post_lcd_on(1344) > [_post_lcd_on:1344] LCD ON as reserved app[(null)] alpm mode[0]
04-06 02:03:35.357+0900 W/W_HOME  (  837): gesture.c: _manual_render(182) > 
04-06 02:03:35.392+0900 W/W_HOME  (  837): gesture.c: _manual_render_enable(138) > 0
04-06 02:03:35.402+0900 W/W_HOME  (  837): dbus.c: _dbus_message_recv_cb(186) > LCD on
04-06 02:03:35.402+0900 W/W_HOME  (  837): gesture.c: _manual_render_disable_timer_set(167) > timer set
04-06 02:03:35.402+0900 W/W_HOME  (  837): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-06 02:03:35.407+0900 W/W_HOME  (  837): gesture.c: _apps_status_get(128) > apps status:0
04-06 02:03:35.407+0900 W/W_HOME  (  837): gesture.c: _lcd_on_cb(303) > move_to_clock:0 clock_visible:0 info->offtime:994
04-06 02:03:35.407+0900 W/W_HOME  (  837): gesture.c: _manual_render_schedule(209) > schedule, manual render
04-06 02:03:35.407+0900 W/W_HOME  (  837): event_manager.c: _lcd_on_cb(721) > lcd state: 1
04-06 02:03:35.407+0900 W/W_HOME  (  837): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-06 02:03:35.407+0900 W/W_HOME  (  837): gesture.c: _widget_updated_cb(188) > widget updated
04-06 02:03:35.407+0900 W/W_HOME  (  837): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-06 02:03:35.407+0900 W/W_HOME  (  837): gesture.c: _manual_render(182) > 
04-06 02:03:35.417+0900 W/W_HOME  (  837): gesture.c: _manual_render_enable(138) > 0
04-06 02:03:35.447+0900 W/TIZEN_N_SOUND_MANAGER( 1292): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
04-06 02:03:35.452+0900 E/WAKEUP-SERVICE( 1292): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-06 02:03:35.452+0900 E/WAKEUP-SERVICE( 1292): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-06 02:03:35.452+0900 I/TIZEN_N_SOUND_MANAGER( 1292): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
04-06 02:03:35.452+0900 I/APP_CORE(  781): appcore-efl.c: __do_app(453) > [APP 781] Event: RESUME State: PAUSED
04-06 02:03:35.452+0900 I/CAPI_APPFW_APPLICATION(  781): app_main.c: app_appcore_resume(223) > app_appcore_resume
04-06 02:03:35.492+0900 W/SHealthCommon( 1233): SystemUtil.cpp: OnDeviceStatusChanged(1041) > [1;35mlcdState:1[0;m
04-06 02:03:35.492+0900 W/SHealthService( 1233): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
04-06 02:03:35.517+0900 I/TIZEN_N_SOUND_MANAGER( 1292): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
04-06 02:03:35.517+0900 W/TIZEN_N_SOUND_MANAGER( 1292): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-06 02:03:35.517+0900 W/WAKEUP-SERVICE( 1292): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
04-06 02:03:35.517+0900 I/HIGEAR  ( 1292): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
04-06 02:03:35.517+0900 W/WAKEUP-SERVICE( 1292): WakeupService.cpp: OnReceiveDisplayChanged(970) > [0;32mINFO: LCDOn receive data : 1075006220[0;m
04-06 02:03:35.517+0900 W/WAKEUP-SERVICE( 1292): WakeupService.cpp: OnReceiveDisplayChanged(971) > [0;32mINFO: WakeupServiceStart[0;m
04-06 02:03:35.517+0900 W/WAKEUP-SERVICE( 1292): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
04-06 02:03:35.517+0900 I/TIZEN_N_SOUND_MANAGER( 1292): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
04-06 02:03:35.532+0900 W/W_INDICATOR(  781): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(285) > [_windicator_dbus_lcd_changed_cb:285] LCD ON signal is received
04-06 02:03:35.532+0900 W/W_INDICATOR(  781): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(304) > [_windicator_dbus_lcd_changed_cb:304] 304, str=[gesture],charge : 0, connected : 0
04-06 02:03:35.532+0900 W/TIZEN_N_SOUND_MANAGER( 1292): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
04-06 02:03:35.532+0900 E/WAKEUP-SERVICE( 1292): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-06 02:03:35.542+0900 E/WAKEUP-SERVICE( 1292): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-06 02:03:35.542+0900 I/TIZEN_N_SOUND_MANAGER( 1292): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
04-06 02:03:35.632+0900 I/TIZEN_N_SOUND_MANAGER( 1292): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
04-06 02:03:35.632+0900 W/TIZEN_N_SOUND_MANAGER( 1292): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-06 02:03:35.632+0900 W/WAKEUP-SERVICE( 1292): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
04-06 02:03:35.632+0900 I/HIGEAR  ( 1292): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
04-06 02:03:35.657+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1233): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
04-06 02:03:35.657+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1233): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
04-06 02:03:35.657+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1233): preference.c: preference_get_boolean(1173) > preference_get_boolean(1233) : test_healthy_pace error
04-06 02:03:35.717+0900 W/SHealthService( 1233): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1007[0;m
04-06 02:03:35.717+0900 W/SHealthCommon( 1233): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1491436800000.000000[0;m
04-06 02:03:35.737+0900 W/SHealthCommon( 1233): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: timeline_summary_updated client list: [2:com.samsung.shealth.widget.hrlog (855347)]][0;m
04-06 02:03:35.782+0900 W/SHealthWidget( 1012): WidgetMain.cpp: widget_update(147) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.widget.hrlog (855347), msgName: timeline_summary_updated[0;m
04-06 02:03:35.782+0900 W/SHealthCommon( 1233): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.1.30][0;m
04-06 02:03:35.782+0900 W/SHealthCommon( 1012): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_summary_updated[0;m
04-06 02:03:35.782+0900 W/SHealthWidget( 1012): HrLogWidgetViewController.cpp: OnIpcProxyMessageReceived(71) > [1;35m##24Hour Widget Service SummaryUpdate Called[0;m
04-06 02:03:35.782+0900 W/WSLib   ( 1012): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1491444215789.000000, pattern:[HH:mm][0;m
04-06 02:03:35.782+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1012): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-06 02:03:35.782+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1012): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-06 02:03:35.782+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1012): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-06 02:03:35.782+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1012): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-06 02:03:35.787+0900 E/WSLib   ( 1012): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale ko_KR[0;m
04-06 02:03:35.787+0900 W/WSLib   ( 1012): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[02:03][0;m
04-06 02:03:35.787+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1012): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-06 02:03:35.787+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1012): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-06 02:03:35.787+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1012): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-06 02:03:35.787+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1012): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-06 02:03:35.787+0900 I/CAPI_WIDGET_APPLICATION( 1012): widget_app.c: __provider_update_cb(281) > received updating signal
04-06 02:03:35.792+0900 I/HealthDataService( 1043): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
04-06 02:03:35.847+0900 I/healthData( 1233): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
04-06 02:03:36.442+0900 E/EFL     (  403): ecore_x<403> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=16779514 button=1
04-06 02:03:36.442+0900 E/EFL     (  781): ecore_x<781> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=16779514 button=1
04-06 02:03:36.462+0900 W/W_INDICATOR(  781): windicator_moment_view.c: windicator_moment_view_battery_disp_timer_cb(737) > [windicator_moment_view_battery_disp_timer_cb:737] [CHARGING_UI] windicator_moment_view_battery_disp_timer_cb
04-06 02:03:36.572+0900 E/EFL     (  781): ecore_x<781> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=16779642 button=1
04-06 02:03:36.687+0900 W/W_INDICATOR(  781): windicator_moment_view.c: _charging_ui_fade_out_end_cb(246) > [_charging_ui_fade_out_end_cb:246] Fade out end. Call moment_view_hide
04-06 02:03:36.687+0900 E/W_INDICATOR(  781): windicator_moment_view.c: windicator_moment_view_hide(1050) > [windicator_moment_view_hide:1050] Hide Moment View , Type(1)
04-06 02:03:36.727+0900 I/APP_CORE(  781): appcore-efl.c: __do_app(453) > [APP 781] Event: PAUSE State: RUNNING
04-06 02:03:36.727+0900 I/CAPI_APPFW_APPLICATION(  781): app_main.c: app_appcore_pause(202) > app_appcore_pause
04-06 02:03:36.952+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1233): preference.c: _preference_check_retry_err(507) > key(test_healthy_pace), check retry err: -21/(2/No such file or directory).
04-06 02:03:36.952+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1233): preference.c: _preference_get_key(1101) > _preference_get_key(test_healthy_pace) step(-17825744) failed(2 / No such file or directory)
04-06 02:03:36.952+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1233): preference.c: preference_get_boolean(1173) > preference_get_boolean(1233) : test_healthy_pace error
04-06 02:03:36.952+0900 W/SHealthService( 1233): ContextPedometerProxy.cpp: OnContextStepLevelMonitorUpdated(1122) > [1;40;33mOnNotWearingStop[0;m
04-06 02:03:37.017+0900 I/APP_CORE(  837): appcore-efl.c: __do_app(453) > [APP 837] Event: MEM_FLUSH State: PAUSED
04-06 02:03:37.042+0900 W/SHealthCommon( 1233): TimelineSessionStorage.cpp: OnTriggered(1268) > [1;40;33mlocalStartTime: 1491436800000.000000[0;m
04-06 02:03:37.067+0900 W/SHealthCommon( 1233): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: timeline_session_updated client list: [2:com.samsung.shealth.widget.hrlog (855347)]][0;m
04-06 02:03:37.107+0900 W/SHealthCommon( 1233): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.1.30][0;m
04-06 02:03:37.107+0900 W/SHealthWidget( 1012): WidgetMain.cpp: widget_update(147) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.widget.hrlog (855347), msgName: timeline_session_updated[0;m
04-06 02:03:37.107+0900 W/SHealthCommon( 1012): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_session_updated[0;m
04-06 02:03:37.107+0900 W/SHealthWidget( 1012): HrLogWidgetViewController.cpp: OnIpcProxyMessageReceived(75) > [1;35m##24Hour Widget Service SessionUpdate Called[0;m
04-06 02:03:37.107+0900 W/WSLib   ( 1012): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1491444217114.000000, pattern:[HH:mm][0;m
04-06 02:03:37.107+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1012): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-06 02:03:37.107+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1012): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-06 02:03:37.107+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1012): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-06 02:03:37.107+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1012): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-06 02:03:37.107+0900 W/SHealthCommon( 1233): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(640) > [1;40;33mSEND SERVICE MESSAGE [name: timeline_summary_updated client list: [2:com.samsung.shealth.widget.hrlog (855347)]][0;m
04-06 02:03:37.112+0900 E/WSLib   ( 1012): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale ko_KR[0;m
04-06 02:03:37.112+0900 W/WSLib   ( 1012): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[02:03][0;m
04-06 02:03:37.112+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1012): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-06 02:03:37.112+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1012): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-06 02:03:37.112+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1012): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-06 02:03:37.112+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1012): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-06 02:03:37.132+0900 W/SHealthAppCommon( 1012): TodayLogItemDataGenerator.cpp: CreateDataList(84) > [1;35m BEGIN >>>>[0;m
04-06 02:03:37.132+0900 W/SHealthAppCommon( 1012): TodayLogItemDataGenerator.cpp: PushSessionEvent(154) > [1;35mTIMELINE :: LIGHT Time[2017/4/6 0:0:0 ~ 2017/4/6 0:22:52], Calorie :[26.035568][0;m
04-06 02:03:37.147+0900 W/SHealthCommon( 1233): SHealthMessagePortConnection.cpp: SendServiceMessageImpl(705) > [1;35mCurrent shealth version [3.1.30][0;m
04-06 02:03:37.147+0900 W/SHealthAppCommon( 1012): TodayLogItemDataGenerator.cpp: PushSessionEvent(157) > [1;35mTIMELINE :: NOTWEARING Time[2017/4/6 0:22:52 ~ 2017/4/6 1:53:53], Calorie :[103.570947][0;m
04-06 02:03:37.152+0900 W/SHealthAppCommon( 1012): TodayLogItemDataGenerator.cpp: PushSessionEvent(154) > [1;35mTIMELINE :: LIGHT Time[2017/4/6 1:53:53 ~ 2017/4/6 2:3:37], Calorie :[11.073941][0;m
04-06 02:03:37.152+0900 W/SHealthAppCommon( 1012): TodayLogItemDataGenerator.cpp: CreateDataList(112) > [1;35m END <<<<[0;m
04-06 02:03:37.152+0900 I/CAPI_WIDGET_APPLICATION( 1012): widget_app.c: __provider_update_cb(281) > received updating signal
04-06 02:03:37.152+0900 I/HealthDataService( 1043): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
04-06 02:03:37.172+0900 I/healthData( 1233): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
04-06 02:03:37.232+0900 W/SHealthWidget( 1012): WidgetMain.cpp: widget_update(147) > [1;40;33mipcClientInfo: 2, com.samsung.shealth.widget.hrlog (855347), msgName: timeline_summary_updated[0;m
04-06 02:03:37.232+0900 W/SHealthCommon( 1012): IpcProxy.cpp: OnServiceMessageReceived(186) > [1;40;33mmsgName: timeline_summary_updated[0;m
04-06 02:03:37.232+0900 W/SHealthWidget( 1012): HrLogWidgetViewController.cpp: OnIpcProxyMessageReceived(71) > [1;35m##24Hour Widget Service SummaryUpdate Called[0;m
04-06 02:03:37.237+0900 W/WSLib   ( 1012): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1491444217242.000000, pattern:[HH:mm][0;m
04-06 02:03:37.237+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1012): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-06 02:03:37.237+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1012): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-06 02:03:37.237+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1012): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-06 02:03:37.237+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1012): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-06 02:03:37.237+0900 E/WSLib   ( 1012): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale ko_KR[0;m
04-06 02:03:37.237+0900 W/WSLib   ( 1012): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[02:03][0;m
04-06 02:03:37.237+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1012): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-06 02:03:37.237+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1012): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-06 02:03:37.237+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1012): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-06 02:03:37.237+0900 E/TIZEN_N_SYSTEM_SETTINGS( 1012): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-06 02:03:37.242+0900 I/CAPI_WIDGET_APPLICATION( 1012): widget_app.c: __provider_update_cb(281) > received updating signal
04-06 02:03:37.267+0900 E/EFL     ( 4445): ecore_x<4445> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=16780337 button=1
04-06 02:03:37.382+0900 E/EFL     ( 4445): ecore_x<4445> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=16780454 button=1
04-06 02:03:38.382+0900 E/EFL     (  403): ecore_x<403> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x3800002 time=16780454
04-06 02:03:38.392+0900 E/EFL     ( 4445): ecore_x<4445> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=16780454
04-06 02:03:38.392+0900 E/EFL     (  403): ecore_x<403> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=16780454
04-06 02:03:39.482+0900 E/EFL     ( 4445): ecore_x<4445> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=16782553 button=1
04-06 02:03:39.622+0900 E/EFL     ( 4445): ecore_x<4445> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=16782680 button=1
04-06 02:03:39.957+0900 W/STARTER (  780): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[837] goes to (3)
04-06 02:03:39.957+0900 E/STARTER (  780): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 837)'s state(3)
04-06 02:03:39.962+0900 W/AUL_AMD (  521): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-06 02:03:39.962+0900 W/AUL_AMD (  521): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
04-06 02:03:39.962+0900 W/AUL     (  521): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(837) status(fg) type(uiapp)
04-06 02:03:39.982+0900 W/AUL_PAD ( 1306): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 4445 pgid = 4445
04-06 02:03:39.982+0900 W/AUL_PAD ( 1306): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
04-06 02:03:40.072+0900 W/PROCESSMGR(  403): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(659) > [PROCESSMGR] =====================> send UpdateClock
04-06 02:03:40.077+0900 W/WATCH_CORE( 9906): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
04-06 02:03:40.077+0900 I/WATCH_CORE( 9906): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
04-06 02:03:40.077+0900 I/CAPI_WATCH_APPLICATION( 9906): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-06 02:03:40.077+0900 E/watchface-loader( 9906): watchface-loader.cpp: OnAppTimeTick(616) > 
04-06 02:03:40.077+0900 I/watchface-loader( 9906): watchface-loader.cpp: OnAppTimeTick(628) > set force update!!
04-06 02:03:40.077+0900 I/watchface-viewer( 9906): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(577) > ImagesLoadingDoneSignal().Emit()
04-06 02:03:40.122+0900 W/AUL_PAD ( 1306): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
04-06 02:03:40.127+0900 W/W_HOME  (  837): event_manager.c: _ecore_x_message_cb(427) > state: 1 -> 0
04-06 02:03:40.127+0900 W/W_HOME  (  837): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-06 02:03:40.127+0900 W/W_HOME  (  837): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-06 02:03:40.127+0900 W/W_HOME  (  837): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-06 02:03:40.127+0900 W/W_HOME  (  837): main.c: _ecore_x_message_cb(996) > main_info.is_win_on_top: 1
04-06 02:03:40.127+0900 W/W_INDICATOR(  781): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
04-06 02:03:40.127+0900 W/W_INDICATOR(  781): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-06 02:03:40.132+0900 W/W_HOME  (  837): event_manager.c: _window_visibility_cb(466) > Window [0x2E00003] is now visible(0)
04-06 02:03:40.132+0900 W/W_HOME  (  837): event_manager.c: _window_visibility_cb(476) > state: 0 -> 1
04-06 02:03:40.132+0900 W/W_HOME  (  837): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-06 02:03:40.132+0900 W/W_HOME  (  837): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-06 02:03:40.132+0900 W/W_HOME  (  837): main.c: _window_visibility_cb(963) > Window [0x2E00003] is now visible(0)
04-06 02:03:40.132+0900 I/APP_CORE(  837): appcore-efl.c: __do_app(453) > [APP 837] Event: RESUME State: PAUSED
04-06 02:03:40.132+0900 I/CAPI_APPFW_APPLICATION(  837): app_main.c: app_appcore_resume(223) > app_appcore_resume
04-06 02:03:40.132+0900 W/W_HOME  (  837): main.c: _appcore_resume_cb(478) > appcore resume
04-06 02:03:40.132+0900 W/W_HOME  (  837): event_manager.c: _app_resume_cb(379) > state: 2 -> 1
04-06 02:03:40.132+0900 W/W_HOME  (  837): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-06 02:03:40.132+0900 W/W_HOME  (  837): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-06 02:03:40.132+0900 W/W_HOME  (  837): main.c: home_resume(526) > journal_multimedia_screen_loaded_home called
04-06 02:03:40.132+0900 W/W_HOME  (  837): main.c: home_resume(530) > clock/widget resumed
04-06 02:03:40.132+0900 E/W_HOME  (  837): retailmode.c: retailmode_enabled_get(245) > failed to get value VCONFKEY_RETAILMODE_ENABLED
04-06 02:03:40.132+0900 W/W_HOME  (  837): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-06 02:03:40.132+0900 I/AUL_AMD (  521): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 4445
04-06 02:03:40.132+0900 W/AUL     (  521): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(4445)
04-06 02:03:40.137+0900 I/wnotib  (  837): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 0
04-06 02:03:40.137+0900 E/wnotib  (  837): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-06 02:03:40.137+0900 W/wnotib  (  837): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(962) > No postponed work with is_for_VI: 0, postponed_for_VI: 0.
04-06 02:03:40.137+0900 W/W_INDICATOR(  781): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 1
04-06 02:03:40.137+0900 W/W_INDICATOR(  781): windicator_battery.c: windicator_battery_vconfkey_register(422) > [windicator_battery_vconfkey_register:422] Set battery cb
04-06 02:03:40.137+0900 W/W_INDICATOR(  781): windicator_battery.c: _battery_update(89) > [_battery_update:89] 
04-06 02:03:40.137+0900 W/W_INDICATOR(  781): windicator_battery.c: windicator_battery_icon_update(277) > [windicator_battery_icon_update:277] battery level(100), length(3)
04-06 02:03:40.137+0900 W/W_INDICATOR(  781): windicator_battery.c: windicator_battery_icon_update(284) > [windicator_battery_icon_update:284] 100%
04-06 02:03:40.137+0900 W/W_INDICATOR(  781): windicator_battery.c: windicator_battery_icon_update(294) > [windicator_battery_icon_update:294] battery_level: 100, isCharging: 0
04-06 02:03:40.137+0900 W/W_INDICATOR(  781): windicator_battery.c: windicator_battery_icon_update(320) > [windicator_battery_icon_update:320] battery file : change_level_100
04-06 02:03:40.137+0900 W/W_INDICATOR(  781): windicator_battery.c: windicator_battery_icon_update(381) > [windicator_battery_icon_update:381] Normal charging status !!
04-06 02:03:40.147+0900 W/WATCH_CORE( 9906): appcore-watch.c: __widget_resume(1124) > widget_resume
04-06 02:03:40.147+0900 W/AUL     ( 9906): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(9906) status(fg) type(watchapp)
04-06 02:03:40.147+0900 E/watchface-loader( 9906): watchface-loader.cpp: OnAppResume(597) > 
04-06 02:03:40.147+0900 I/watchface-viewer( 9906): viewer-data-provider.cpp: FlushPendingChanges(2241) > notify pending [50]
04-06 02:03:40.147+0900 I/watchface-viewer( 9906): viewer-data-provider.cpp: FlushPendingChanges(2241) > notify pending [52]
04-06 02:03:40.147+0900 I/CAPI_WATCH_APPLICATION( 9906): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-06 02:03:40.147+0900 E/watchface-loader( 9906): watchface-loader.cpp: OnAppTimeTick(616) > 
04-06 02:03:40.147+0900 I/watchface-viewer( 9906): viewer-part-resource-evas.cpp: CreateTextImage(613) > inline-image index[0]
04-06 02:03:40.147+0900 I/watchface-viewer( 9906): viewer-part-resource-evas.cpp: CreateTextImage(807) > style[DEFAULT='font=Default font_size=40 color=#FFFFFF ellipsis=-1 align=center ']
04-06 02:03:40.147+0900 I/watchface-viewer( 9906): viewer-part-resource-evas.cpp: CreateTextImage(821) > formatted size 99x46
04-06 02:03:40.147+0900 I/watchface-viewer( 9906): viewer-part-resource-evas.cpp: UpdateEvasTextblockItems(955) > cursor 24x2 at (51,44)
04-06 02:03:40.152+0900 I/watchface-viewer( 9906): viewer-part-resource-evas.cpp: UpdateEvasTextblockItems(969) > image 24x46 at (51,0)
04-06 02:03:40.152+0900 I/watchface-viewer( 9906): viewer-part-resource-evas.cpp: CreateTextImage(613) > inline-image index[0]
04-06 02:03:40.152+0900 I/watchface-viewer( 9906): viewer-part-resource-evas.cpp: CreateTextImage(807) > style[DEFAULT='font=Default font_size=40 color=#FFFFFF ellipsis=-1 align=center ']
04-06 02:03:40.152+0900 I/watchface-viewer( 9906): viewer-part-resource-evas.cpp: CreateTextImage(821) > formatted size 99x46
04-06 02:03:40.152+0900 I/watchface-viewer( 9906): viewer-part-resource-evas.cpp: UpdateEvasTextblockItems(955) > cursor 24x2 at (63,44)
04-06 02:03:40.152+0900 I/watchface-viewer( 9906): viewer-part-resource-evas.cpp: UpdateEvasTextblockItems(969) > image 24x46 at (63,0)
04-06 02:03:40.152+0900 I/watchface-viewer( 9906): viewer-part-resource-evas.cpp: CreateTextImage(613) > inline-image index[0]
04-06 02:03:40.152+0900 I/watchface-viewer( 9906): viewer-part-resource-evas.cpp: CreateTextImage(807) > style[DEFAULT='font=Default font_size=40 color=#FFFFFF ellipsis=-1 align=center ']
04-06 02:03:40.152+0900 I/watchface-viewer( 9906): viewer-part-resource-evas.cpp: CreateTextImage(821) > formatted size 99x46
04-06 02:03:40.152+0900 I/watchface-viewer( 9906): viewer-part-resource-evas.cpp: UpdateEvasTextblockItems(955) > cursor 24x2 at (74,44)
04-06 02:03:40.152+0900 I/watchface-viewer( 9906): viewer-part-resource-evas.cpp: UpdateEvasTextblockItems(969) > image 24x46 at (74,0)
04-06 02:03:40.152+0900 I/watchface-viewer( 9906): viewer-image-file-loader.cpp: OnImageLoadingDoneIdlerCb(577) > ImagesLoadingDoneSignal().Emit()
04-06 02:03:40.197+0900 I/CAPI_WATCH_APPLICATION( 9906): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-06 02:03:40.197+0900 E/watchface-loader( 9906): watchface-loader.cpp: OnAppTimeTick(616) > 
04-06 02:03:40.232+0900 W/CRASH_MANAGER( 4578): worker.c: worker_job(1205) > 110444568656c149141181
