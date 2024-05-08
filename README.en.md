# MobileControlGuru (Support HotKey, WebAPI Control,Multi-device)

<h3><a href="README.md">简体中文</a> | English</h3>

<a href="Docs/Update.en.md">Update Log</a>

## Feature

1. Multi-device control
2. Bulk operations
3. Support HotKey
4. API Control

## Instructions for use

1. run MobileControlGuru.exe
2. Enable the debugging mode of the phone and authorize the debugging
3. Click to get the list of devices
4. Click to get the device list, the device information appears in the left list, and you can start to control the phone (no screen projection required).


## Matters needing attention

Close directly will not exit this program, please click the icon in the lower right corner to exit this program

### HotKey

By default, only the first device is operated

| HotKey | Action|
| --- | --- | 
|  Alt+D|  Lock|  
|  Alt+H|  Home|  
|  Alt+C|  Tap screen|  
|  Alt+↑| Volume plus |
|  Alt+↓| Volume down |
|  Alt+←| MediaPrevious|
|  Alt+→| MediaNext|
|  Alt+NumPad55| MediaPlayPause|
|  Alt+NumPad2| Swipe up（TikTok videos next）|
|  Alt+NumPad8| Swipe down（TikTok videos up）|

### API Description

This feature is used to control non-native devices and should be enabled with caution.

After enabling this feature, local network devices can invoke control commands for the local machine through API requests.

This feature match[Curl](https://curl.se/download.html)and [AutoHotkey](https://[AutoHotkey](https://www.autohotkey.com/)), When multiple devices can let their respective computers operate their own phones
Example AutoHotkey script Look at <a href="Docs/autohotkey.md">autohotkey.ahk</a> in the docs directory

#### API List

By default, the WebPort is enabled on port 12345. You need to enter the config file to modify Webport properties

|Url | Description|
| --- | --- | 
| /api/Device/Connect| Connecting devices by IP (Step 1) | 
| /api/Device/List | List of current devices |  
| /api/Device/Lock |Send the lock screen command |
| /api/Device/SendKey|  Send keyCode value Please search for the key (adb keycode) |
| /api/Device/SendSwipe | Send Swipe |

## Preview

Main

![image](https://github.com/yclown/MobileControlGuru/blob/master/Preview/main.png)

IP Connect

![image](https://github.com/yclown/MobileControlGuru/blob/master/Preview/ipconnect.png)

API

![image](https://github.com/yclown/MobileControlGuru/blob/master/Preview/api.png)


