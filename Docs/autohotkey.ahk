device :="192.168.191.3"
api_url :="http://192.168.8.242:12345"

;锁屏
!1::
{
    
   Run 'curl "' . api_url . '/api/Device/Lock?devicename=' . device . '"',,"hide"
}
;音量-
!Down::
{
    
   Run 'curl "' . api_url . '/api/Device/SendKey?devicename=' . device . '&Key=KEYCODE_VOLUME_DOWN"',,"hide"
}
;音量+
!Up::
{
    
   Run 'curl "' . api_url . '/api/Device/SendKey?devicename=' . device . '&Key=KEYCODE_VOLUME_UP"',,"hide"
}

;多媒体 下一个
!Right::
{
    
   Run 'curl "' . api_url . '/api/Device/SendKey?devicename=' . device . '&Key=KEYCODE_MEDIA_NEXT"',,"hide"
}
 
;多媒体 上一个
!Left::
{
    
   Run 'curl "' . api_url . '/api/Device/SendKey?devicename=' . device . '&KEYCODE_MEDIA_PLAY_PAUSE"',,"hide"
}
 ;多媒体 暂停播放
!Numpad5::
{
    
   Run 'curl "' . api_url . '/api/Device/SendKey?devicename=' . device . '&Key=KEYCODE_MEDIA_PLAY"',,"hide"
}
 ;上滑
!q::
{
    
   Run 'curl "' . api_url . '/api/Device/SendSwipe?devicename=' . device . '&direct=up"',,"hide"
}
 
;下滑
!w::
{
    
   Run 'curl "' . api_url . '/api/Device/SendSwipe?devicename=' . device . '&direct=down"',,"hide"
}
 
;桌面
!2::
{
    
   Run 'curl "' . api_url . '/api/Device/SendKey?devicename=' . device . '&Key=3"',,"hide"
}

;检查设备连接情况
CheckConnection() {  
   ; 使用Run而不是RunWait，这样我们可以看到curl的输出  
   OutputVar :=ExecScript('curl --connect-timeout 5 "' . api_url . '/api/Device/List"')
   ;MsgBox "Result: " OutputVar

   If not InStr(OutputVar, device){
      MsgBox "设备已经掉线"
      Pause  
   }
      
}  


;测试
!t::
{
   CheckConnection()

}

ExecScript(Script, Wait:=true)
{
   shell := ComObject("WScript.Shell")
   exec := shell.Exec(Script)
   ; exec.StdIn.Write(Script)
   exec.StdIn.Close()
   if Wait
       return exec.StdOut.ReadAll()
}
;隐藏控制台
DllCall("AllocConsole")
WinHide   "ahk_id " DllCall("GetConsoleWindow", "ptr")
; 设置定时器，每5分钟调用一次RunBatchFile函数  
; 注意：时间是以毫秒为单位的，所以5分钟是5 * 60 * 1000 = 300000毫秒  
SetTimer  CheckConnection, 5000  ; 5分钟定时器   