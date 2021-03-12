# wpTrackerCS

*A Multiple-Monitor Wallpaper Tracker*  
  
## Contents

1. [System Requirements](#1-system-requirements)
2. [Overview](#2-overview)
3. [Installation](#3-installation)
4. [Usage](#4-usage)
5. [Version History](#5-version-history)

-------

## 1. System Requirements

- Windows 8/10 with native wallpaper slideshow enabled
- about 1 megabyte of disk space
- about 10 megabytes of memory space

## 2. Overview

wpTrackerCS is a simple program that provides a notification icon to inform
the user which monitor's wallpaper changed last, and at what time.

It can also be used to view the full filepath of each current wallpaper, and
open them.

## 3. Installation

wpTrackerCS is too simple to have an installer. Just copy the exe to wherever
you want to use it from. I suggest you create a new folder at
`%PROGRAMFILES%\Nitemice Software`, and put in there, but it's totally up to
you.

If you want wpTrackerCS to run at startup, create a shortcut to it in
`%APPDATA%\Microsoft\Windows\Start Menu\Programs\Startup`
for just your user, or
`%PROGRAMDATA%\Microsoft\Windows\Start Menu\Programs\Startup` for all users.

You may also want to make the icon always visible in the system tray, by
following the steps set out
[here by How-To Geek](http://www.howtogeek.com/75510/beginner-how-to-customize-and-tweak-your-system-tray-icons-in-windows-7/).

## 4. Usage

Once you've run wpTrackerCS, you should see an icon in the system tray that
looks like a screen with a number on it. The number indicates which monitor's
wallpaper changed last. This icon will automatically update whenever a change
is detected.

If you put your mouse over the icon, you should see a tooltip which says
"Last WP Change: Screen X @ Y:YY AM/PM", with X being the number of the monitor
which last changed, and Y:YY AM/PM being the time when it changed in 12hr time.
This is also updated when the icon is updated, and is also visible on the main
window.

To open the main window, simply double-click on the icon, or right-click on
it, and choose "Open". From here, you can view a list of filepaths of all of
the wallpapers currently on display, across all monitors. To open any of these
files, simply double-click the filepath and it will open in the default image
viewer.

If, at any point you want to force an update, you can either right-click on the
icon and choose "Update Now", or open the main window, and click the "Check
Now" button.

To exit the program, right-click on the icon and choose "Exit".

## 5. Version History
  
- 4.0.0 (12/03/2021): Replaced timer with registry monitor, added wp filepath list
- 3.3.0 (14/02/2015): Altered registry path & added some support for 4-16 monitors
- 3.2.0 (27/10/2014): Updated registry-checking mechanism to be more robust  
- 3.1.0 (05/09/2014): Rewritten in C#, added interval-saving feature  
- 1.3.0 (11/08/2014): Added time-checking of when last wp change occurred  
- 1.1.0 (25/05/2013): Initial release build, added support for up to 3 monitors  
- 1.0.0 (19/03/2014): Initial concept build  
