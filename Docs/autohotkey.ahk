;设备IP 无需端口号
device :="192.168.191.3"
;锁屏
!e::
{
    
   Run 'curl "http://192.168.8.242:12345/api/Device/Lock?devicename=' . device . '"',,"hide"
}
;音量-
!Down::
{
    
   Run 'curl "http://192.168.8.242:12345/api/Device/SendKey?devicename=' . device . '&Key=KEYCODE_VOLUME_DOWN"',,"hide"
}
;音量+
!Up::
{
    
   Run 'curl "http://192.168.8.242:12345/api/Device/SendKey?devicename=' . device . '&Key=KEYCODE_VOLUME_UP"',,"hide"
}

;多媒体 下一个
!Right::
{
    
   Run 'curl "http://192.168.8.242:12345/api/Device/SendKey?devicename=' . device . '&Key=KEYCODE_MEDIA_NEXT"',,"hide"
}
 
;多媒体 上一个
!Left::
{
    
   Run 'curl "http://192.168.8.242:12345/api/Device/SendKey?devicename=' . device . '&Key=KEYCODE_MEDIA_PREVIOUS"',,"hide"
}
 ;多媒体 暂停播放
!Numpad5::
{
    
   Run 'curl "http://192.168.8.242:12345/api/Device/SendKey?devicename=' . device . '&Key=KEYCODE_MEDIA_PLAY"',,"hide"
}
 ;上滑
!Numpad2::
{
    
   Run 'curl "http://192.168.8.242:12345/api/Device/SendSwipe?devicename=' . device . '&direct=up"',,"hide"
}
 
;下滑
!Numpad8::
{
    
   Run 'curl "http://192.168.8.242:12345/api/Device/SendSwipe?devicename=' . device . '&direct=down"',,"hide"
}
 