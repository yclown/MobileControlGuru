# 任务说明
通过corn表达式来进行任务调度
多任务尚未测试，如果bug及时反馈

# 操作说明
1. 进入任务列表
2. 编辑任务信息
3. 开启任务（默认启动都要手动开启）
4. 任务保存在程序目录中的 task.json

# 操作和参数

| 操作 | 参数示例| 备注 |
| --- | --- | --- | 
|  点击 | 500 500| 输入 x y 坐标，坐标可通过调试打开显示坐标显示，有些手机需要开启模拟点击才能运行 |
|  滑动 | 540 1300 540 500 1000 | 5个数字,表示从哪里滑动到哪里， 最后一个是时间，时间越长滑动越慢  |
|  按键 | KEYCODE_HOME（或3） |字符或者数字 可搜索安卓keyevent 找到对应的键码   |
|  启动APP | com.alibaba.android.rimet/com.alibaba.android.rimet.biz.LaunchHomeActivity | 启动app需要获取到app的Activity 自行搜索 安卓启动xxx app  |
|  睡眠 | 500 1500（或 500） | 单位毫秒 填一个数字就是固定睡眠，两个数字，随机在两个值之间时长  |
|  自定义命令 | 无 | 自定义cmd指令，可以运行控制台执行  |

# corn表达式
自行搜索corn表达式

# 任务示例
```json
[
 {
    "Name": "每5秒下滑",
    "TaskItems": [
      {
        "Oprate": "shell input swipe",
        "Param": "540 1300 540 500 1000",
        "IsAdb": true
      }
    ],
    "id": 1,
    "RunTimes": 1,
    "DeviceName": "419218f7",
    "Corn": "0/5 * * * * ?",
    "IsRun": true
  }
]
```

## 界面预览

任务列表

![image](https://github.com/yclown/MobileControlGuru/blob/master/Preview/taskmain.png)

任务编辑

![image](https://github.com/yclown/MobileControlGuru/blob/master/Preview/taskedit.png)