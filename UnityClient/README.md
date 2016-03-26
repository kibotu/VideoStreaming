Unity client for video streams
-------------------------------

Tiny client that will load a video stream by url.


##### Requirements

[Easy Movie Texture](https://www.assetstore.unity3d.com/en/#!/content/1003) Version: 3.13+ (Mar 07, 2016)+

[Oculus Mobile SDK](https://developer.oculus.com/downloads/) V1.0.0.1 

[Oculus Utilities for Unity 5 ](https://developer.oculus.com/downloads/)  V0.1.3.0-beta

##### Oculus Certificate

You will need the device id certificate for development purposes.

1. Get the certificate
For that go to [https://developer.oculus.com/osig/](https://developer.oculus.com/osig/) and download the file using your [android.os.Build.Serial](http://developer.android.com/reference/android/os/Build.html#SERIAL) which you can also see when installing the app https://play.google.com/store/apps/details?id=net.kibotu.android.deviceinfo.
2. Store the file in 
    
    Project/Assets/Plugins/Android/assets/ 
    
##### Oculus Project Settings

    ovr_sdk_mobile_1.0.0.1\VrSamples\Unity\SDKExamples\ProjectSettings