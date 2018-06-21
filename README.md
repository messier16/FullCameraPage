# FullCameraPage
An attempt to bring this https://github.com/ThatCSharpGuy/Forms-FullCameraPage to .NET Standard

A detailed description of how this works can be found here [Full page camera in Xamarin.Forms](https://thatcsharpguy.com/post/full-camera-page.1/).  

## Permissions

On **Android** add the following lines to your Manifest

```xml
<uses-permission android:name="android.permission.CAMERA" />
<uses-feature android:name="android.hardware.camera" />
<uses-feature android:name="android.hardware.camera.autofocus" />
```

On **iOS** add the follwing lines to your Info.plist (make sure you explain to your users why you need the camera)

```xml
<key>NSCameraUsageDescription</key>
<string>I need access to your camera to take some photos!</string>
```

### Warning

The Android API that this camera uses has been deprecated a long time ago and will be removed in a future Android release. That being said, if you want to help me upgrade this example, you'll get this horrible hard shell taco 🌮 and my full appreciation.  
