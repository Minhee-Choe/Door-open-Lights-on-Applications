# Door-open-Lights-on-Apps
Android and Tizen apps for a smartphone and a smartwatch that sense the door opening motion from the watch and light the flashlight of the smartphone.

This project was for a course named 'software capstone design' in 2017, the details of which can be found in pdf, pptx, and mp4 files. 
There are two applications: 'FlashLights' - Android application written in Java and 'HelloAccel' - Tizen application written in C.
They interact each other via Bluetooth. 

Tizen application compares the motion obtained from machine learning in advance with the input motion. If the motions match each other, it sends bluetooth signal to the android application, and the smartphone light the embedded flashlight. 
