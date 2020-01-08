S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.2.1
Build-Number: R720XXU2EPK5
Build-Date: 2016.11.25 12:47:41

Crash Information
Process Name: helloaccel
PID: 4555
Date: 2017-04-06 02:04:50+0900
Executable File Path: /opt/usr/apps/org.example.helloaccel/bin/helloaccel
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 4555, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x80000000, r3   = 0x00000000
r4   = 0x0000001a, r5   = 0x418f9c12
r6   = 0x418d29a0, r7   = 0xbea5f210
r8   = 0x00000000, r9   = 0x43f83eb8
r10  = 0x43f909a0, fp   = 0x00000001
ip   = 0x404f30b0, sp   = 0xbea5efa8
lr   = 0x418f94cb, pc   = 0x404f30b4
cpsr = 0x60000010

Memory Information
MemTotal:   490112 KB
MemFree:      4940 KB
Buffers:     20892 KB
Cached:     106492 KB
VmPeak:     107084 KB
VmSize:     105048 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       18732 KB
VmRSS:       18732 KB
VmData:      42532 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25560 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 4555 TID = 4555
4555 4713 4714 4715 4718 

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
41390000 41394000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4139c000 413a4000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
413a6000 413ab000 r-xp /usr/lib/libappcore-common.so.1.1
413b3000 413b5000 r-xp /usr/lib/libiniparser.so.0
413be000 413c9000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
413d4000 413d8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
413e1000 413e3000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
413ec000 413f2000 r-xp /usr/lib/libappsvc.so.0.1.0
413fa000 4141e000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
41427000 414f6000 r-xp /usr/lib/libscim-1.0.so.8.2.3
4150c000 41516000 r-xp /lib/libnss_files-2.13.so
416b2000 416df000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.2
416e8000 416f4000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
416fd000 4171e000 r-xp /usr/lib/libefl-extension.so.0.1.0
41726000 41750000 r-xp /usr/lib/libsensor.so.1.9.5
41759000 41760000 r-xp /usr/lib/libctx-shared.so.0.8.3
41768000 4176d000 r-xp /usr/lib/libctx-client.so.0.8.3
41775000 41787000 r-xp /usr/lib/libefl-assist.so.0.1.0
4178f000 41799000 r-xp /usr/lib/libsensord-shared.so
417a1000 417b0000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
417b9000 417ba000 r-xp /usr/lib/libxcb-shm.so.0.0.0
417c3000 418f7000 rw-p [heap]
418f7000 418fa000 r-xp /opt/usr/apps/org.example.helloaccel/bin/helloaccel
41cdb000 41e63000 r-xp /usr/lib/libicui18n.so.57.1
41e73000 41f79000 r-xp /usr/lib/libicuuc.so.57.1
41f8f000 42047000 r-xp /usr/lib/libcairo.so.2.11200.14
438e3000 438f9000 r-xp /usr/lib/libtts.so
43902000 43925000 r-xp /usr/lib/libui-extension.so.0.1.0
4392e000 43939000 r-xp /usr/lib/libtbm.so.1.0.0
43941000 4394f000 r-xp /usr/lib/libGLESv2.so.2.0
43958000 4395e000 r-xp /usr/lib/libxcb-render.so.0.0.0
43966000 43969000 r-xp /usr/lib/libEGL.so.1.4
43971000 43976000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
4397e000 43981000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
43989000 4398a000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
43993000 4399b000 r-xp /usr/lib/libdrm.so.2.4.0
439a3000 439a5000 r-xp /usr/lib/libdri2.so.0.0.0
439ad000 439b3000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
439bb000 439c0000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
439c8000 439e1000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
439e9000 43a0a000 r-xp /usr/lib/libexif.so.12.3.3
43a1d000 43a1f000 r-xp /usr/lib/libttrace.so.1.1
43a27000 43a2c000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
43a34000 43a3a000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
43a43000 43a4b000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
43a53000 43a75000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
43a7e000 43a85000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
43a8e000 43a90000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
43a98000 43a9f000 r-xp /usr/lib/libminizip.so.1.0.0
43aa7000 43ab4000 r-xp /usr/lib/libail.so.0.1.0
43abd000 43ac3000 r-xp /usr/lib/libproc-stat.so.0.2.96
43acb000 43acc000 r-xp /usr/lib/libresponse.so.0.2.96
43ad4000 43ad9000 r-xp /usr/lib/libsystem.so.0.0.0
43ae3000 43bad000 r-xp /usr/lib/libCOREGL.so.4.0
43ef0000 43efb000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43f04000 43f09000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43f11000 43f28000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
440f8000 448f7000 rw-p [stack:4713]
448f8000 450f7000 rw-p [stack:4714]
450f8000 458f7000 rw-p [stack:4715]
458f7000 458f8000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
45a01000 46200000 rw-p [stack:4718]
46295000 4629d000 r-xp /usr/lib/libfeedback.so.0.1.4
4629f000 462a0000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
462a8000 462aa000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
462b2000 462bd000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
462c5000 462cc000 r-xp /usr/lib/libmmfcommon.so.0.0.0
462d4000 462ec000 r-xp /usr/lib/libmmfsound.so.0.1.0
462fd000 46301000 r-xp /usr/lib/libmmfsession.so.0.0.0
4630a000 46315000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
46322000 46326000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
4632e000 46344000 r-xp /usr/lib/libavsysaudio.so.0.0.1
4634c000 463ad000 r-xp /usr/lib/libasound.so.2.0.0
463b7000 463ba000 r-xp /usr/lib/libpulse-simple.so.0.0.4
463c2000 463fa000 r-xp /usr/lib/libpulse.so.0.16.2
463fb000 463fe000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
46406000 4644e000 r-xp /usr/lib/libmdm.so.1.2.62
4644f000 46452000 r-xp /usr/lib/libtinycompress.so.0.0.0
4645a000 4645f000 r-xp /usr/lib/libjson.so.0.0.1
46467000 464b0000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
464b9000 46500000 r-xp /usr/lib/libsndfile.so.1.0.26
4650c000 4651b000 r-xp /usr/lib/libmdm-common.so.1.1.22
46524000 46546000 r-xp /usr/lib/libvorbis.so.0.4.3
4654e000 46552000 r-xp /usr/lib/libogg.so.0.7.1
bea3f000 bea60000 rw-p [stack]
End of Maps Information

Callstack Information (PID:4555)
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
01 is null
04-06 02:04:45.462+0900 I/ELM_RPANEL(  837): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
04-06 02:04:45.462+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x4605cc98 : elm_scroller] ECORE_CALLBACK_RENEW : px(934), py(0)
04-06 02:04:45.462+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x4605cc98 : elm_scroller] time(0.595547)
04-06 02:04:45.462+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x4605cc98 : elm_scroller] ECORE_CALLBACK_RENEW : px(934), py(0)
04-06 02:04:45.477+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x4605cc98 : elm_scroller] time(0.669693)
04-06 02:04:45.477+0900 I/ELM_RPANEL(  837): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
04-06 02:04:45.477+0900 I/ELM_RPANEL(  837): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
04-06 02:04:45.477+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x4605cc98 : elm_scroller] ECORE_CALLBACK_RENEW : px(961), py(0)
04-06 02:04:45.477+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x4605cc98 : elm_scroller] time(0.669693)
04-06 02:04:45.482+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x4605cc98 : elm_scroller] ECORE_CALLBACK_RENEW : px(961), py(0)
04-06 02:04:45.497+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x4605cc98 : elm_scroller] time(0.736335)
04-06 02:04:45.497+0900 I/ELM_RPANEL(  837): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
04-06 02:04:45.497+0900 I/ELM_RPANEL(  837): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
04-06 02:04:45.497+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x4605cc98 : elm_scroller] ECORE_CALLBACK_RENEW : px(985), py(0)
04-06 02:04:45.497+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x4605cc98 : elm_scroller] time(0.736335)
04-06 02:04:45.497+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x4605cc98 : elm_scroller] ECORE_CALLBACK_RENEW : px(985), py(0)
04-06 02:04:45.507+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x4605cc98 : elm_scroller] time(0.795451)
04-06 02:04:45.512+0900 I/ELM_RPANEL(  837): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
04-06 02:04:45.512+0900 I/ELM_RPANEL(  837): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
04-06 02:04:45.512+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x4605cc98 : elm_scroller] ECORE_CALLBACK_RENEW : px(1006), py(0)
04-06 02:04:45.512+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x4605cc98 : elm_scroller] time(0.795451)
04-06 02:04:45.512+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x4605cc98 : elm_scroller] ECORE_CALLBACK_RENEW : px(1006), py(0)
04-06 02:04:45.527+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x4605cc98 : elm_scroller] time(0.847114)
04-06 02:04:45.527+0900 I/ELM_RPANEL(  837): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
04-06 02:04:45.527+0900 I/ELM_RPANEL(  837): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
04-06 02:04:45.532+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x4605cc98 : elm_scroller] ECORE_CALLBACK_RENEW : px(1024), py(0)
04-06 02:04:45.532+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x4605cc98 : elm_scroller] time(0.847114)
04-06 02:04:45.532+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x4605cc98 : elm_scroller] ECORE_CALLBACK_RENEW : px(1024), py(0)
04-06 02:04:45.547+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x4605cc98 : elm_scroller] time(0.891295)
04-06 02:04:45.547+0900 I/ELM_RPANEL(  837): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
04-06 02:04:45.547+0900 I/ELM_RPANEL(  837): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
04-06 02:04:45.547+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x4605cc98 : elm_scroller] ECORE_CALLBACK_RENEW : px(1040), py(0)
04-06 02:04:45.547+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x4605cc98 : elm_scroller] time(0.891295)
04-06 02:04:45.547+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x4605cc98 : elm_scroller] ECORE_CALLBACK_RENEW : px(1040), py(0)
04-06 02:04:45.557+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x4605cc98 : elm_scroller] time(0.927871)
04-06 02:04:45.562+0900 I/ELM_RPANEL(  837): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
04-06 02:04:45.562+0900 I/ELM_RPANEL(  837): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
04-06 02:04:45.562+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x4605cc98 : elm_scroller] ECORE_CALLBACK_RENEW : px(1054), py(0)
04-06 02:04:45.562+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x4605cc98 : elm_scroller] time(0.927871)
04-06 02:04:45.562+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x4605cc98 : elm_scroller] ECORE_CALLBACK_RENEW : px(1054), py(0)
04-06 02:04:45.577+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x4605cc98 : elm_scroller] time(0.957052)
04-06 02:04:45.577+0900 I/ELM_RPANEL(  837): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
04-06 02:04:45.577+0900 I/ELM_RPANEL(  837): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
04-06 02:04:45.577+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x4605cc98 : elm_scroller] ECORE_CALLBACK_RENEW : px(1064), py(0)
04-06 02:04:45.577+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x4605cc98 : elm_scroller] time(0.957052)
04-06 02:04:45.577+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x4605cc98 : elm_scroller] ECORE_CALLBACK_RENEW : px(1064), py(0)
04-06 02:04:45.592+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x4605cc98 : elm_scroller] time(0.978731)
04-06 02:04:45.592+0900 I/ELM_RPANEL(  837): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
04-06 02:04:45.592+0900 I/ELM_RPANEL(  837): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
04-06 02:04:45.597+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x4605cc98 : elm_scroller] ECORE_CALLBACK_RENEW : px(1072), py(0)
04-06 02:04:45.597+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x4605cc98 : elm_scroller] time(0.978731)
04-06 02:04:45.597+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x4605cc98 : elm_scroller] ECORE_CALLBACK_RENEW : px(1072), py(0)
04-06 02:04:45.607+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x4605cc98 : elm_scroller] time(0.992709)
04-06 02:04:45.607+0900 I/ELM_RPANEL(  837): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
04-06 02:04:45.607+0900 I/ELM_RPANEL(  837): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
04-06 02:04:45.612+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x4605cc98 : elm_scroller] ECORE_CALLBACK_RENEW : px(1077), py(0)
04-06 02:04:45.612+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x4605cc98 : elm_scroller] time(0.992709)
04-06 02:04:45.612+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x4605cc98 : elm_scroller] ECORE_CALLBACK_RENEW : px(1077), py(0)
04-06 02:04:45.627+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x4605cc98 : elm_scroller] time(0.999418)
04-06 02:04:45.627+0900 I/ELM_RPANEL(  837): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
04-06 02:04:45.627+0900 I/ELM_RPANEL(  837): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
04-06 02:04:45.627+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2564 _elm_scroll_scroll_to_x_animator() [0x4605cc98 : elm_scroller] ECORE_CALLBACK_RENEW : px(1079), py(0)
04-06 02:04:45.627+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x4605cc98 : elm_scroller] time(0.999418)
04-06 02:04:45.627+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2612 _elm_scroll_scroll_to_y_animator() [0x4605cc98 : elm_scroller] ECORE_CALLBACK_RENEW : px(1079), py(0)
04-06 02:04:45.642+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2541 _elm_scroll_scroll_to_x_animator() [0x4605cc98 : elm_scroller] time(0.998624)
04-06 02:04:45.642+0900 I/ELM_RPANEL(  837): elm-rpanel.c: _panel_swap_effect(3225) > tobj_item_01 is null
04-06 02:04:45.642+0900 I/ELM_RPANEL(  837): elm-rpanel.c: _panel_swap_effect(3280) > tobj_item_02 is null
04-06 02:04:45.642+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2559 _elm_scroll_scroll_to_x_animator() [0x4605cc98 : elm_scroller] ECORE_CALLBACK_CANCEL : px(1080), py(0)
04-06 02:04:45.642+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2589 _elm_scroll_scroll_to_y_animator() [0x4605cc98 : elm_scroller] time(0.998624)
04-06 02:04:45.642+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2604 _elm_scroll_scroll_to_y_animator() [0x4605cc98 : elm_scroller] animation stop!!
04-06 02:04:45.647+0900 W/wnotib  (  837): w-notification-board-panel-manager.c: _wnb_pm_anim_stop_cb(96) > notiboard scroller anim stop [1080][0][360][360]
04-06 02:04:45.647+0900 W/wnotib  (  837): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(969) > No postponed update with is_for_VI: 1.
04-06 02:04:45.647+0900 W/W_HOME  (  837): home_navigation.c: _anim_stop_cb(1316) > anim stop
04-06 02:04:45.647+0900 W/W_HOME  (  837): home_navigation.c: _nav_finish_timer_del(822) > delete timer
04-06 02:04:45.647+0900 W/W_HOME  (  837): home_navigation.c: _nav_finish_timer_add(850) > add timer:1
04-06 02:04:45.647+0900 W/W_HOME  (  837): home_navigation.c: _nav_finish_timer_add(854) > add timer:2
04-06 02:04:45.647+0900 I/efl-extension(  837): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(489) > [0x4605cc98 : elm_scroller] detent_count(1)
04-06 02:04:45.647+0900 I/efl-extension(  837): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(490) > [0x4605cc98 : elm_scroller] pagenumber_v(0), pagenumber_h(3)
04-06 02:04:45.647+0900 I/efl-extension(  837): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(512) > [0x4605cc98 : elm_scroller] CurrentPage(3)
04-06 02:04:45.647+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:2607 _elm_scroll_scroll_to_y_animator() [0x4605cc98 : elm_scroller] ECORE_CALLBACK_CANCEL : px(1080), py(0)
04-06 02:04:45.652+0900 E/weather-widget(  988): WidgetMain.cpp: WidgetLifeCycleChangedCb(873) > [0;40;31mwidgetInstanceId:file:///opt/usr/share/live_magazine/com.samsung.weather-widget_837_23.258785.png, instanceId:/opt/usr/share/live_magazine/com.samsung.weather-widget_837_23.258785.png[0;m
04-06 02:04:45.652+0900 E/weather-widget(  988): WidgetViewData.cpp: SetWidgetLifeCycleEvent(1607) > [0;40;31mSetWidgetLifeCycleEvent, mWidgetLifeCycleEvent:3[0;m
04-06 02:04:45.652+0900 E/weather-widget(  988): WidgetMain.cpp: PauseWidgetInstance(1064) > [0;40;31mPauseWidgetInstance[0;m
04-06 02:04:45.662+0900 E/weather-widget(  988): WidgetMainView.cpp: HideActivityIndicator(1064) > [0;40;31m[HideActivityIndicator(): 1064] (refreshButtonLayout == NULL) [return][0;m
04-06 02:04:45.662+0900 E/weather-widget(  988): WidgetMainView.cpp: Pause(3539) > [0;40;31mOnClosed[0;m
04-06 02:04:45.662+0900 E/weather-widget(  988): WidgetMainView.cpp: LableSlidingStop(3465) > [0;40;31msliding stop[0;m
04-06 02:04:45.662+0900 E/weather-widget(  988): WidgetMain.cpp: DeleteUpdateTimerData(278) > [0;40;31m[DeleteUpdateTimerData(): 278] (size < 1) [return][0;m
04-06 02:04:45.677+0900 E/weather-widget(  988): WidgetMain.cpp: PauseWidgetInstance(1095) > [0;40;31mlocationID : 4113500000:CurrentCity[0;m
04-06 02:04:45.677+0900 I/CAPI_WIDGET_APPLICATION(  988): widget_app.c: __provider_pause_cb(298) > widget obj was paused
04-06 02:04:45.677+0900 W/AUL     (  988): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.weather-widget) pid(988) status(bg) type(widgetapp)
04-06 02:04:45.677+0900 I/CAPI_WIDGET_APPLICATION(  988): widget_app.c: __check_status_for_cgroup(145) > enter background group
04-06 02:04:45.732+0900 I/CAPI_WIDGET_APPLICATION(  992): widget_app.c: __provider_resume_cb(316) > widget obj was resumed
04-06 02:04:45.732+0900 W/AUL     (  992): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.app-widget.widget) pid(992) status(fg) type(widgetapp)
04-06 02:04:45.732+0900 I/CAPI_WIDGET_APPLICATION(  992): widget_app.c: __check_status_for_cgroup(134) > enter foreground group
04-06 02:04:45.762+0900 E/W_HOME  (  837): retailmode.c: retailmode_enabled_get(245) > failed to get value VCONFKEY_RETAILMODE_ENABLED
04-06 02:04:45.772+0900 W/W_HOME  (  837): event_manager.c: _home_scroll_cb(585) > scroll,will,done
04-06 02:04:45.772+0900 W/W_HOME  (  837): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-06 02:04:45.772+0900 W/W_HOME  (  837): event_manager.c: _home_scroll_cb(585) > scroll,done
04-06 02:04:45.772+0900 W/W_HOME  (  837): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-06 02:04:46.147+0900 W/W_HOME  (  837): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
04-06 02:04:46.307+0900 E/EFL     (  837): ecore_x<837> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=16849379 button=1
04-06 02:04:46.307+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x4605cc98 : elm_scroller] mouse move
04-06 02:04:46.312+0900 W/W_HOME  (  837): home_navigation.c: _nav_finish_timer_del(822) > delete timer
04-06 02:04:46.342+0900 E/EFL     (  992): evas_main<992> evas_object_main.c:1440 evas_object_color_set() Evas only handles pre multiplied colors!
04-06 02:04:46.342+0900 E/EFL     (  992): evas_main<992> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
04-06 02:04:46.342+0900 E/EFL     (  992): evas_main<992> evas_object_main.c:1450 evas_object_color_set() Evas only handles pre multiplied colors!
04-06 02:04:46.372+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x4605cc98 : elm_scroller] mouse move
04-06 02:04:46.372+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x4605cc98 : elm_scroller] hold(0), freeze(0)
04-06 02:04:46.377+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:4002 _elm_scroll_mouse_move_event_cb() [0x4605cc98 : elm_scroller] mouse move
04-06 02:04:46.377+0900 E/EFL     (  837): elementary<837> elm_interface_scrollable.c:4166 _elm_scroll_mouse_move_event_cb() [0x4605cc98 : elm_scroller] hold(0), freeze(0)
04-06 02:04:46.387+0900 E/EFL     (  837): ecore_x<837> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=16849454 button=1
04-06 02:04:46.392+0900 W/W_HOME  (  837): home_navigation.c: _up_cb(1247) > up
04-06 02:04:46.392+0900 W/W_HOME  (  837): home_navigation.c: _nav_finish_timer_del(822) > delete timer
04-06 02:04:46.392+0900 W/W_HOME  (  837): home_navigation.c: _nav_finish_timer_add(854) > add timer:2
04-06 02:04:46.412+0900 W/AUL     (  992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(com.samsung.w-home)
04-06 02:04:46.412+0900 W/AUL_AMD (  521): amd_request.c: __request_handler(669) > __request_handler: 0
04-06 02:04:46.412+0900 W/AUL_AMD (  521): amd_launch.c: _start_app(1782) > caller pid : 992
04-06 02:04:46.412+0900 I/AUL_AMD (  521): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
04-06 02:04:46.422+0900 W/AUL     (  521): app_signal.c: aul_send_app_resume_request_signal(567) > aul_send_app_resume_request_signal app(com.samsung.w-home) pid(837) type(uiapp) bg(2)
04-06 02:04:46.422+0900 W/AUL_AMD (  521): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 837
04-06 02:04:46.422+0900 I/APP_CORE(  837): appcore-efl.c: __do_app(453) > [APP 837] Event: RESET State: RUNNING
04-06 02:04:46.422+0900 I/CAPI_APPFW_APPLICATION(  837): app_main.c: app_appcore_reset(245) > app_appcore_reset
04-06 02:04:46.422+0900 W/CAPI_APPFW_APP_CONTROL(  837): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-06 02:04:46.422+0900 W/AUL_AMD (  521): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(837), cmd(0)
04-06 02:04:46.422+0900 E/W_HOME  (  837): retailmode.c: retailmode_enabled_get(245) > failed to get value VCONFKEY_RETAILMODE_ENABLED
04-06 02:04:46.422+0900 W/W_HOME  (  837): main.c: _app_control_progress(1568) > Service value : launch_apps
04-06 02:04:46.422+0900 W/W_HOME  (  837): move.c: move_move_to_apps(216) > move to apps
04-06 02:04:46.422+0900 W/W_HOME  (  837): rotary.c: rotary_attach(138) > rotary_attach:0x48ce3f18
04-06 02:04:46.422+0900 I/efl-extension(  837): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x48ce3f18, elm_layout, _activated_obj : 0x46076260, activated : 1
04-06 02:04:46.422+0900 I/efl-extension(  837): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
04-06 02:04:46.422+0900 W/W_HOME  (  837): event_manager.c: _move_module_anim_start_cb(666) > state: 0 -> 1
04-06 02:04:46.422+0900 W/W_HOME  (  837): event_manager.c: _state_control(176) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-06 02:04:46.422+0900 W/W_HOME  (  837): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-06 02:04:46.422+0900 W/AUL     (  992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(837)
04-06 02:04:46.422+0900 W/STARTER (  780): pkg-monitor.c: _app_mgr_status_cb(416) > [_app_mgr_status_cb:416] Resume request [837]
04-06 02:04:46.427+0900 E/APP_SHORTCUT_WIDGET(  992): main.c: _tts_button_mouse_clicked_cb(732) >  (tts_status == 0) -> _tts_button_mouse_clicked_cb() return
04-06 02:04:46.432+0900 W/W_INDICATOR(  781): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
04-06 02:04:46.432+0900 W/W_INDICATOR(  781): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-06 02:04:46.432+0900 W/APPS    (  837): AppsViewNecklace.cpp: setBubbleColor(2455) >  [249, 249, 249, 255]
04-06 02:04:46.437+0900 I/APP_CORE(  837): appcore-efl.c: __do_app(529) > Legacy lifecycle: 1
04-06 02:04:46.442+0900 W/W_HOME  (  837): event_manager.c: _apptray_visibility_cb(604) > apps,show,start
04-06 02:04:46.442+0900 W/W_HOME  (  837): event_manager.c: _apptray_visibility_cb(624) > state: 1 -> 0
04-06 02:04:46.442+0900 W/W_HOME  (  837): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-06 02:04:46.442+0900 W/W_HOME  (  837): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-06 02:04:46.442+0900 W/W_HOME  (  837): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-06 02:04:46.442+0900 W/W_HOME  (  837): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-06 02:04:46.442+0900 W/W_HOME  (  837): noti_broker.c: _apptray_visibility_cb(786) > apps,show,start
04-06 02:04:46.442+0900 W/W_HOME  (  837): noti_broker.c: noti_broker_event_fire_to_plugin(1003) > source:1 event:80002
04-06 02:04:46.442+0900 W/wnotib  (  837): w-notification-board-broker-main.c: _wnotib_view_event_handler(1308) > Home view event: 0x80002
04-06 02:04:46.442+0900 I/wnotib  (  837): w-notification-board-broker-main.c: _wnotib_view_event_handler(1418) > Unhandled type: 0x80002
04-06 02:04:46.447+0900 W/W_INDICATOR(  781): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
04-06 02:04:46.447+0900 W/W_INDICATOR(  781): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-06 02:04:46.712+0900 W/W_HOME  (  837): event_manager.c: _move_module_anim_end_cb(680) > state: 1 -> 0
04-06 02:04:46.712+0900 W/W_HOME  (  837): event_manager.c: _state_control(176) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-06 02:04:46.712+0900 W/W_HOME  (  837): rotary.c: rotary_deattach(156) > rotary_deattach:0x48ce3f18
04-06 02:04:46.712+0900 I/efl-extension(  837): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
04-06 02:04:46.712+0900 I/efl-extension(  837): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x48ce3f18, elm_layout, func : 0x4005653d
04-06 02:04:46.712+0900 I/efl-extension(  837): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
04-06 02:04:46.712+0900 I/efl-extension(  837): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
04-06 02:04:46.712+0900 I/efl-extension(  837): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
04-06 02:04:46.712+0900 I/efl-extension(  837): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x46076260, elm_box, _activated_obj : 0x48ce3f18, activated : 1
04-06 02:04:46.712+0900 I/efl-extension(  837): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
04-06 02:04:46.712+0900 E/wnotib  (  837): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-06 02:04:46.712+0900 I/wnotib  (  837): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1225) > No second depth view available.
04-06 02:04:46.712+0900 W/W_HOME  (  837): event_manager.c: _apptray_visibility_cb(604) > apps,show
04-06 02:04:46.712+0900 W/W_HOME  (  837): event_manager.c: _apptray_visibility_cb(624) > state: 1 -> 1
04-06 02:04:46.712+0900 W/W_HOME  (  837): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-06 02:04:46.712+0900 W/W_HOME  (  837): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-06 02:04:46.712+0900 W/W_HOME  (  837): main.c: home_pause(546) > clock/widget paused
04-06 02:04:46.712+0900 W/W_HOME  (  837): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-06 02:04:46.712+0900 W/APPS    (  837): apps_main.c: _time_changed_cb(308) >  date : 6->6
04-06 02:04:46.712+0900 W/APPS    (  837): AppsViewNecklace.cpp: setBubbleColor(2455) >  [249, 249, 249, 255]
04-06 02:04:46.712+0900 W/W_HOME  (  837): rotary.c: rotary_attach(138) > rotary_attach:0x4732f1f0
04-06 02:04:46.712+0900 I/efl-extension(  837): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x4732f1f0, elm_layout, _activated_obj : 0x46076260, activated : 1
04-06 02:04:46.712+0900 I/efl-extension(  837): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
04-06 02:04:46.717+0900 W/W_HOME  (  837): win.c: win_back_gesture_disable_set(170) > disable back gesture
04-06 02:04:46.717+0900 W/W_HOME  (  837): win.c: win_back_gesture_disable_set(170) > disable back gesture
04-06 02:04:46.717+0900 W/W_HOME  (  837): event_manager.c: _state_control(176) > control:5, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-06 02:04:46.717+0900 W/W_HOME  (  837): noti_broker.c: _apptray_visibility_cb(786) > apps,show
04-06 02:04:46.717+0900 W/W_HOME  (  837): noti_broker.c: noti_broker_event_fire_to_plugin(1003) > source:1 event:80000
04-06 02:04:46.717+0900 W/wnotib  (  837): w-notification-board-broker-main.c: _wnotib_view_event_handler(1308) > Home view event: 0x80000
04-06 02:04:46.717+0900 I/wnotib  (  837): w-notification-board-noti-manager.c: wnb_nm_app_tray_changed_cb(1030) > is_app_tray_displayed: 1
04-06 02:04:46.717+0900 W/wnotib  (  837): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [16], notiboard card appending count [31].
04-06 02:04:46.717+0900 E/APPS    (  837): apps_main.c: apps_main_resume(1003) >  resumed already
04-06 02:04:46.717+0900 W/W_INDICATOR(  781): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
04-06 02:04:46.717+0900 W/W_INDICATOR(  781): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-06 02:04:46.732+0900 E/APP_SHORTCUT_WIDGET(  992): main.c: widget_instance_pause(1669) >  (!popup) -> widget_instance_pause() return
04-06 02:04:46.732+0900 I/CAPI_WIDGET_APPLICATION(  992): widget_app.c: __provider_pause_cb(298) > widget obj was paused
04-06 02:04:46.732+0900 W/AUL     (  992): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.app-widget.widget) pid(992) status(bg) type(widgetapp)
04-06 02:04:46.737+0900 I/CAPI_WIDGET_APPLICATION(  992): widget_app.c: __check_status_for_cgroup(145) > enter background group
04-06 02:04:46.892+0900 W/W_HOME  (  837): index.c: index_hide(337) > hide VI:1 visibility:0 vi:(nil)
04-06 02:04:47.072+0900 E/EFL     (  837): ecore_x<837> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=16850144 button=1
04-06 02:04:47.077+0900 W/APPS    (  837): AppsViewNecklace.cpp: touchPressed(1639) >  TOUCH [221, 221]
04-06 02:04:47.077+0900 W/APPS    (  837): AppsViewNecklace.cpp: onBubbleButtonEffect(2404) >  [249, 249, 249, 102]
04-06 02:04:47.077+0900 E/EFL     (  837): evas_main<837> evas_object_main.c:1440 evas_object_color_set() Evas only handles pre multiplied colors!
04-06 02:04:47.077+0900 E/EFL     (  837): evas_main<837> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
04-06 02:04:47.077+0900 E/EFL     (  837): evas_main<837> evas_object_main.c:1450 evas_object_color_set() Evas only handles pre multiplied colors!
04-06 02:04:47.077+0900 E/W_HOME  (  837): util.c: util_is_rdu_retailmode(1372) > Cannot get the vconf for retailmode
04-06 02:04:47.137+0900 E/EFL     (  837): ecore_x<837> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=16850212 button=1
04-06 02:04:47.137+0900 W/APPS    (  837): AppsViewNecklace.cpp: touchReleased(1952) >  TOUCH [221, 221]->[218, 219]
04-06 02:04:47.142+0900 W/APPS    (  837): AppsViewNecklace.cpp: onBubbleButtonEffect(2422) >  [249, 249, 249, 255]
04-06 02:04:47.142+0900 W/APPS    (  837): AppsItem.cpp: onItemClicked(463) >  onItemClicked[0,15]
04-06 02:04:47.142+0900 E/APPS    (  837): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
04-06 02:04:47.142+0900 W/APPS    (  837): AppsItem.cpp: onItemClicked(487) >  item(helloaccel) launched, open(0), tts(0)
04-06 02:04:47.142+0900 W/AUL     (  837): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.helloaccel)
04-06 02:04:47.142+0900 W/AUL_AMD (  521): amd_request.c: __request_handler(669) > __request_handler: 0
04-06 02:04:47.147+0900 W/AUL_AMD (  521): amd_launch.c: _start_app(1782) > caller pid : 837
04-06 02:04:47.147+0900 I/AUL_AMD (  521): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
04-06 02:04:47.157+0900 W/AUL_AMD (  521): amd_launch.c: _start_app(2218) > pad pid(-5)
04-06 02:04:47.157+0900 W/AUL_PAD ( 1306): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
04-06 02:04:47.157+0900 W/AUL_PAD ( 1306): launchpad.c: __send_result_to_caller(272) > Check app launching
04-06 02:04:47.157+0900 E/RESOURCED(  584): block.c: block_prelaunch_state(138) > insert data org.example.helloaccel, table num : 6
04-06 02:04:47.157+0900 W/AUL_PAD ( 4555): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
04-06 02:04:47.157+0900 W/AUL_PAD ( 4555): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
04-06 02:04:47.157+0900 W/AUL_PAD ( 4555): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
04-06 02:04:47.157+0900 W/AUL_PAD ( 4555): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.helloaccel)
04-06 02:04:47.207+0900 I/efl-extension( 4555): efl_extension.c: eext_mod_init(40) > Init
04-06 02:04:47.212+0900 I/UXT     ( 4555): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
04-06 02:04:47.212+0900 W/AUL_PAD ( 4555): launchpad_loader.c: main(690) > [candidate] dlsym
04-06 02:04:47.212+0900 W/AUL_PAD ( 4555): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.helloaccel)
04-06 02:04:47.212+0900 I/CAPI_APPFW_APPLICATION( 4555): app_main.c: ui_app_main(704) > app_efl_main
04-06 02:04:47.217+0900 I/CAPI_APPFW_APPLICATION( 4555): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
04-06 02:04:47.257+0900 W/AUL     (  521): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.helloaccel) pid(4555) type(uiapp) bg(0)
04-06 02:04:47.257+0900 W/AUL_AMD (  521): amd_status.c: __socket_monitor_cb(1277) > (4555) was created
04-06 02:04:47.257+0900 E/AUL     (  521): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
04-06 02:04:47.257+0900 W/STARTER (  780): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [4555]
04-06 02:04:47.257+0900 W/AUL     (  837): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4555)
04-06 02:04:47.257+0900 W/W_HOME  (  837): util.c: apps_util_launch_main_operation(643) > Launch app:[helloaccel] ret:[0]
04-06 02:04:47.332+0900 E/EFL     ( 4555): ecore_evas<4555> ecore_evas_extn.c:2204 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
04-06 02:04:47.432+0900 I/APP_CORE( 4555): appcore-efl.c: __do_app(453) > [APP 4555] Event: RESET State: CREATED
04-06 02:04:47.432+0900 I/CAPI_APPFW_APPLICATION( 4555): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
04-06 02:04:47.452+0900 I/APP_CORE( 4555): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
04-06 02:04:47.452+0900 I/APP_CORE( 4555): appcore-efl.c: __do_app(524) > [APP 4555] Initial Launching, call the resume_cb
04-06 02:04:47.452+0900 I/CAPI_APPFW_APPLICATION( 4555): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
04-06 02:04:47.502+0900 I/MALI    (  837): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x43ec6728] swap changed from sync to async
04-06 02:04:47.507+0900 W/W_HOME  (  837): event_manager.c: _ecore_x_message_cb(427) > state: 0 -> 1
04-06 02:04:47.507+0900 W/W_HOME  (  837): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-06 02:04:47.507+0900 W/W_HOME  (  837): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-06 02:04:47.507+0900 W/W_INDICATOR(  781): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
04-06 02:04:47.507+0900 W/W_INDICATOR(  781): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-06 02:04:47.507+0900 W/APP_CORE( 4555): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6200002
04-06 02:04:47.507+0900 W/W_HOME  (  837): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-06 02:04:47.507+0900 W/W_HOME  (  837): win.c: win_back_gesture_disable_set(173) > enable back gesture
04-06 02:04:47.507+0900 W/W_HOME  (  837): main.c: _ecore_x_message_cb(996) > main_info.is_win_on_top: 0
04-06 02:04:47.597+0900 I/APP_CORE( 4555): appcore-efl.c: __do_app(453) > [APP 4555] Event: RESUME State: RUNNING
04-06 02:04:47.602+0900 W/W_HOME  (  837): event_manager.c: _window_visibility_cb(466) > Window [0x2E00003] is now visible(1)
04-06 02:04:47.602+0900 W/W_HOME  (  837): event_manager.c: _window_visibility_cb(476) > state: 1 -> 0
04-06 02:04:47.602+0900 W/W_HOME  (  837): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-06 02:04:47.602+0900 W/W_HOME  (  837): event_manager.c: _state_control(326) > appcore paused manually
04-06 02:04:47.602+0900 W/W_HOME  (  837): main.c: home_appcore_pause(514) > Home Appcore Paused
04-06 02:04:47.602+0900 W/W_HOME  (  837): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
04-06 02:04:47.602+0900 W/W_HOME  (  837): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-06 02:04:47.607+0900 W/W_HOME  (  837): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-06 02:04:47.607+0900 W/W_HOME  (  837): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
04-06 02:04:47.607+0900 W/W_HOME  (  837): rotary.c: rotary_deattach(156) > rotary_deattach:0x4732f1f0
04-06 02:04:47.607+0900 I/efl-extension(  837): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
04-06 02:04:47.607+0900 I/efl-extension(  837): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x4732f1f0, elm_layout, func : 0x4005653d
04-06 02:04:47.607+0900 I/efl-extension(  837): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
04-06 02:04:47.607+0900 I/efl-extension(  837): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
04-06 02:04:47.607+0900 I/efl-extension(  837): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
04-06 02:04:47.607+0900 I/efl-extension(  837): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x46076260, elm_box, _activated_obj : 0x4732f1f0, activated : 1
04-06 02:04:47.607+0900 I/efl-extension(  837): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
04-06 02:04:47.607+0900 E/wnotib  (  837): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-06 02:04:47.607+0900 I/wnotib  (  837): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1225) > No second depth view available.
04-06 02:04:47.607+0900 W/W_HOME  (  837): win.c: win_back_gesture_disable_set(173) > enable back gesture
04-06 02:04:47.612+0900 W/AUL     (  521): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(837) status(bg) type(uiapp)
04-06 02:04:47.612+0900 W/W_INDICATOR(  781): windicator.c: _home_screen_clock_visibility_changed_cb(989) > [_home_screen_clock_visibility_changed_cb:989] Clock visibility : 0
04-06 02:04:47.612+0900 W/W_INDICATOR(  781): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-06 02:04:47.612+0900 W/STARTER (  780): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[837] goes to (4)
04-06 02:04:47.612+0900 E/STARTER (  780): pkg-monitor.c: _proc_mgr_status_cb(452) > [_proc_mgr_status_cb:452] >>>>H(pid 837)'s state(4)
04-06 02:04:47.617+0900 W/AUL_AMD (  521): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-06 02:04:47.617+0900 W/AUL_AMD (  521): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
04-06 02:04:47.617+0900 W/AUL     (  521): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(org.example.helloaccel) pid(4555) status(fg) type(uiapp)
04-06 02:04:47.617+0900 W/STARTER (  780): pkg-monitor.c: _proc_mgr_status_cb(450) > [_proc_mgr_status_cb:450] >> P[4555] goes to (3)
04-06 02:04:47.622+0900 I/MESSAGE_PORT(  498): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-06 02:04:47.622+0900 I/MESSAGE_PORT(  498): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-06 02:04:47.622+0900 I/MESSAGE_PORT(  498): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-06 02:04:47.622+0900 I/MESSAGE_PORT(  498): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-06 02:04:47.622+0900 I/MESSAGE_PORT(  498): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-06 02:04:47.622+0900 I/MESSAGE_PORT(  498): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-06 02:04:47.622+0900 I/MESSAGE_PORT(  498): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-06 02:04:47.622+0900 I/MESSAGE_PORT(  498): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-06 02:04:47.622+0900 I/MESSAGE_PORT(  498): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-06 02:04:47.622+0900 I/MESSAGE_PORT(  498): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-06 02:04:47.622+0900 I/MESSAGE_PORT(  498): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-06 02:04:47.622+0900 I/MESSAGE_PORT(  498): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-06 02:04:47.622+0900 I/MESSAGE_PORT(  498): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-06 02:04:47.622+0900 I/MESSAGE_PORT(  498): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-06 02:04:47.622+0900 I/MESSAGE_PORT(  498): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-06 02:04:47.622+0900 I/MESSAGE_PORT(  498): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-06 02:04:47.622+0900 I/MESSAGE_PORT(  498): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-06 02:04:47.622+0900 I/MESSAGE_PORT(  498): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-06 02:04:47.627+0900 E/CAPI_APPFW_APP_CONTROL( 1245): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-06 02:04:47.627+0900 W/MUSIC_CONTROL_SERVICE( 1245): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:1245]   [com.samsung.w-home]register msg port [false][0m
04-06 02:04:47.627+0900 W/W_HOME  (  837): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
04-06 02:04:47.627+0900 W/W_HOME  (  837): main.c: _window_visibility_cb(963) > Window [0x2E00003] is now visible(1)
04-06 02:04:47.627+0900 I/APP_CORE(  837): appcore-efl.c: __do_app(453) > [APP 837] Event: PAUSE State: RUNNING
04-06 02:04:47.627+0900 I/CAPI_APPFW_APPLICATION(  837): app_main.c: app_appcore_pause(202) > app_appcore_pause
04-06 02:04:47.627+0900 W/W_HOME  (  837): main.c: _appcore_pause_cb(487) > appcore pause
04-06 02:04:47.627+0900 E/W_HOME  (  837): main.c: _pause_cb(465) > paused already
04-06 02:04:47.627+0900 I/wnotib  (  837): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(755) > fully_obscured: 1
04-06 02:04:47.627+0900 E/wnotib  (  837): w-notification-board-action.c: wnb_action_is_drawer_hidden(4797) > [NULL==g_wnb_action_data] msg Drawer not initialized.
04-06 02:04:47.627+0900 W/wnotib  (  837): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(985) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [16], notiboard card appending count [31].
04-06 02:04:47.637+0900 W/APPS    (  837): AppsViewNecklace.cpp: onPausedIdlerCb(5156) >  elm_cache_all_flush
04-06 02:04:47.997+0900 E/AUL     (  521): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
04-06 02:04:48.127+0900 I/APP_CORE(  837): appcore-efl.c: __do_app(453) > [APP 837] Event: MEM_FLUSH State: PAUSED
04-06 02:04:48.522+0900 W/AUL_AMD (  521): amd_request.c: __request_handler(669) > __request_handler: 14
04-06 02:04:48.532+0900 W/AUL_AMD (  521): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 4555
04-06 02:04:48.537+0900 W/AUL_AMD (  521): amd_request.c: __request_handler(669) > __request_handler: 12
04-06 02:04:48.567+0900 E/EFL     ( 4555): ecore_x<4555> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=16851640 button=1
04-06 02:04:48.572+0900 W/AUL_AMD (  521): amd_request.c: __request_handler(669) > __request_handler: 14
04-06 02:04:48.587+0900 W/AUL_AMD (  521): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 4555
04-06 02:04:48.587+0900 W/AUL_AMD (  521): amd_request.c: __request_handler(669) > __request_handler: 12
04-06 02:04:48.672+0900 E/EFL     ( 4555): ecore_x<4555> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=16851747 button=1
04-06 02:04:48.902+0900 I/AUL_PAD ( 4720): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
04-06 02:04:49.592+0900 E/EFL     ( 4555): ecore_x<4555> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=16852659 button=1
04-06 02:04:49.677+0900 E/EFL     (  403): ecore_x<403> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x6200002 time=16851747
04-06 02:04:49.687+0900 E/EFL     ( 4555): ecore_x<4555> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=16851747
04-06 02:04:49.687+0900 E/EFL     (  403): ecore_x<403> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=16851747
04-06 02:04:49.727+0900 E/EFL     ( 4555): ecore_x<4555> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=16852799 button=1
04-06 02:04:50.272+0900 E/EFL     ( 4555): ecore_x<4555> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=16853347 button=1
04-06 02:04:50.397+0900 E/EFL     ( 4555): ecore_x<4555> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=16853470 button=1
04-06 02:04:50.707+0900 W/CRASH_MANAGER( 4738): worker.c: worker_job(1205) > 110455568656c149141189
