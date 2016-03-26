Android client for video streams
--------------------------------

Tiny client that will load a video stream by url.

How to install

    gradle installDebug
    
How to run

    adb shell am start  -n "net.kibotu.android.streaming/net.kibotu.android.streaming.FullscreenActivity" -a android.intent.action.MAIN -c android.intent.category.LAUNCHER