[![Build Status](https://travis-ci.org/abatsakidis/usb_locker.svg?branch=master)](https://travis-ci.org/abatsakidis/usb_locker)
[![Build status](https://ci.appveyor.com/api/projects/status/6hg1u44n4g53mhgc?svg=true)](https://ci.appveyor.com/project/abatsakidis/usb-locker)
[![Codacy Badge](https://api.codacy.com/project/badge/Grade/79e174e8c51d417f94160cc427caaf88)](https://www.codacy.com/app/a.batsakidis/usb_locker?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=abatsakidis/usb_locker&amp;utm_campaign=Badge_Grade)

## Description ##

A Simple USB Desktop Locker for Windows Systems.

One USB drive will be plugged into your computer and whenever any one trying to plug out the pen drive the computer will 
be locked. 

After unlocking the computer if the pen drive is not plugged in then also the computer will be locked, Computer will be 
unlocked only if the pen drive is plugged in.

The application will search for a specific filename into the USB drive which must have a specific string inside. 

You could change these properties using the "settings" parameter.

## How To ##

* First run the application using the parameter **"settings"** : ex. **./usb_locker.exe settings**
![Alt text](/screenshots/settings.jpg?raw=true "USB Locker Settings")
* Save the properties.
* Create the USB Locker Device with the specific file and content.
* Run the application without any parameter.
* The application will check if there is any USB device with the specific file and content. If not, it will lock the computer.

## Tested on ##

**OS**: Windows 10 x86_64 <br>
**CPU**: Intel 2 Quad Q6600 (4) @ 2.400GHz <br>
**Memory**: 2690MiB / 4085MiB <br>

## Build ##

* Use Visual Studio 2017<br>
* Open application's solution file (USBLocker.sln)<br>

## Author ##

Batsakidis Athanasios<br>
Security Consultant<br>
a.batsakidis@re-think.gr
