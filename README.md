# 电脑多控手机（MobileControlGuru）

电脑控制手机的桌面应用，帮助小伙伴愉快的摸鱼

## 功能

1. 手机多控
2. 批量操作
3. 快捷键操作
4. API发布

## 使用说明

1. 打开MobileControlGuru.exe
2. 手机开启调试模式并授权调试
3. 点击获取设备列表
4. 左边列表出现设备信息,即可开始控制手机（无需投屏）

## 注意事项

直接关闭不会退出本程序，请右击右下角图标退出本程序

### 快捷键说明

快捷键默认只操作第一个设备

| 快捷键 | 操作|
| --- | --- | 
|  Alt+D|  锁屏|  
|  Alt+↑| 音量加 |
|  Alt+↓| 音量减 |
|  Alt+←| 媒体键 上一个|
|  Alt+→| 媒体键 下一个|
|  Alt+5(小键盘)| 媒体键 播放暂停|
|  Alt+2(小键盘)| 上滑（对应短视频下一个）|
|  Alt+8(小键盘)| 下滑（对应短视频上一个）|

### API说明

此功能用于非本机控制设备，需要谨慎开启。

开始后局域网设备可以通过API形式调用本机的控制指令

此功能搭配[Curl](https://curl.se/download.html)与[AutoHotkey](https://[AutoHotkey](https://www.autohotkey.com/))配合使用，当多设备时可以让各自的电脑操作自己的手机
AutoHotkey脚本示例查看docs目录下的AutoHotkey.ahk

#### API 列表

默认在12345端口打开，需要请自行进入config文件修改WebPort属性

|地址 | 说明|
| --- | --- | 
| /api/Device/Connect| 通过IP连接设备（第一步） | 
| /api/Device/List | 当前的设备列表 |  
| /api/Device/Lock | 发送锁屏指令 |
| /api/Device/SendKey|  发送按键 keyCode数值请自行搜索关键（adb keycode） |
| /api/Device/SendSwipe | 发送滑动指令 |

## 界面预览

主界面

![image](https://github.com/yclown/MobileControlGuru/blob/master/Preview/main.png)

IP连接

![image](https://github.com/yclown/MobileControlGuru/blob/master/Preview/ipconnect.png)

API

![image](https://github.com/yclown/MobileControlGuru/blob/master/Preview/api.png)


## 项目计划

1. 优化操作
2. 更好多设备支持



