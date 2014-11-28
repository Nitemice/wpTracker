  wpTrackerCS v3.2.0 by Nitemice, 2014
 =====================================
  
  Contents 
  1. System Requirements
  2. Overview
  3. Installation
  4. Usage
  5. Version History
  6. Terms of Use & Disclaimer
  7. Contact Information


 1. System Requirements
 ----------------------
 - Windows 7 onwards with native wallpaper slideshow enabled
 - about 1 megabyte of free space on hard disk  
 - about 30 megabytes of free memory

 2. Overview
 -----------
  wpTrackerCS is a simple program that provides a notification icon to inform
   the user which monitor's wallpaper changed last, and at what time. 

 3. Installation
 ---------------
  wpTrackerCS is too simple to have an installer. Just copy the .exe to wherever
   you want to use it from. I suggest you create a new folder at 
   `C:\Program Files\Nitemice Software`, and put in there, but it's totally up to you.

  If you want wpTrackerCS to run at startup, create a shortcut to it in 
   `C:\users\%username%\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup`
   for just your user, or `C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Startup`
   for all users.

   You may also want to make the icon always visible in the system tray, 
   by following the steps set out 
   [here by How-To Geek](http://www.howtogeek.com/75510/beginner-how-to-customize-and-tweak-your-system-tray-icons-in-windows-7/).

  wpTrackerCS save a setting (your chosen check interval) to a settings file in:
   `C:\Users\%username%\Local Settings\Application Data\wpTrackerCS`
  If you would rather not have this feature, you can use wpTracker (v1.3),
   which is exactly the same program, but written in VB and without this feature.

4. Usage
--------
  Once you've run wpTrackerCS, you should see an icon in the system tray
   that looks like a screen with a number on it. The number indicates which monitor's 
   wallpaper changed last. This icon will automatically update, by default,
   every 30 seconds.

  If you put your mouse over the icon, you should see a tooltip which says 
   "Last WP Change: Screen X @ Y:YY AM/PM", with X being the number of the screen
   which last changed, and Y:YY AM/PM being the time that it changed at in 12hr time.
   This is also updated when the icon is updated.

  To open the options screen, simply double-click on the icon, or right-click on it,
   and choose "Open Options". 

  From here, you can change how often the program checks for wallpaper updates,
   by changing the value in the number box. This value is remembered between 
   runs by saving the value in application settings (See '3. Installation' for
   more details about this).

  To hide the Options screen again, you can either click the "Hide Me!" button, 
   or simply close the window as you normally would. 

  If, at any point you want to force an update of which wallpaper changed last, 
   you can either right-click on the icon and choose "Update Now", 
   or open the Options window, and click the "Check Now!" button.

  To exit the program, right-click on the icon and choose "Exit".

5. Version History
------------------
  3.2.0 (27/10/2014) : Updated registry-checking mechanism to be more robust
  3.1.0 (5/9/2014) : Rewritten in C#, added interval-saving feature
  1.3 (11/8/2014) : Added time-checking of when last wp change occurred
  1.1 (25/5/2013) : Initial release build, added support for up to 3 monitors
  1.0 (19/3/2014) : Initial concept build

6. Terms of Use & Disclaimer
----------------------------
  This software is licensed under The MIT License (MIT)
	Copyright (c) 2014 Nitemice
 
	Permission is hereby granted, free of charge, to any person obtaining a copy of 
	this software and associated documentation files (the "Software"), to deal in the
	Software without restriction, including without limitation the rights to use,
	copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the
	Software, and to permit persons to whom the Software is furnished to do so,
	subject to the following conditions:
 
	The above copyright notice and this permission notice shall be included in all 
	copies or substantial portions of the Software.
 
	THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
	IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
	FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE 
	AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
	WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN 
	CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
  
7. Contact Information
----------------------
 Nitemice Software
  Visit my site: http://nitemice.net
  Email me: contact@nitemice.net