Heart rate monitor
==================

A lightweight program to display the heart rate reading from a 
[Bluetooth Low Energy device](https://www.bluetooth.com/specifications/gatt/viewer?attributeXmlFile=org.bluetooth.characteristic.heart_rate_measurement.xml).

This has only been tested on a [Polar H7](https://www.amazon.com/dp/B007S088F4) (non-referral link) but others should work.

Requires Windows 8.1 or newer.

The executable and code are released under MIT license.

Motivation
----------
I owned a Polar H7 I could not get to work with any iOS software for use in the
gym. I decided to repurpose it as a way to read my heartrate while I worked on
my computer. Having found no software, I decided to create my own.

The program's secondary purpose is for Twitch streamers, because having looked
into their setups, I found there was a mixture of excessive hardware and
software needed. I am not a Twitch streamer and am willing to add the
customizations needed by request.

How to use
----------
[Download prebuilt binaries](https://github.com/jlennox/HeartRate/releases) or
build from source.

I do not have the time to turn this into production grade software but I am
willing to expand it to your needs. At startup, the program searches for an
appropriate device and attempts to register a notification event for
heart_rate_measurement. If this fails, the error is likely vague and not overly
helpful. If you believe your device should work with this software but does
not, please open a github issue with specifics.

This will not work for any general USB/bluetooth heart rate monitor. It has to
be a Bluetooth Low Energy device supporting heart_rate_measurement.

By default, only an icon in the system tray is displayed. When the heart rate
goes over an alert threshold, a balloon notification shows.

Clicking the system tray icon reveals a window with scaling text. This is for
Twitch streamers to be able to region for broadcast.

Right clicking the system tray icon gives the option to edit an XML settings
file. When the editor is closed, the settings will be reloaded automatically.
The file is %appdata%\HeartRate\settings.xml