# ec500-MusicApp
Final project for EC500 A2 spring 2021

**AR Piano App**
This project was created with Unity 2020.3.5f1 and Vuforia Engine 9.8

## Set up
1. Follow this link to download Unity: https://unity3d.com/get-unity/download
2. Follow this link to add Vuforia to your Unity project: https://developer.vuforia.com/downloads/sdk
3. Add ARcamera and ImageTarget by navigating to GameObject -> Vuforia Engine -> ARCamera / ImageTarget
4. To use Vuforia engine, create a Vuforia Developer account then go to developer (https://developer.vuforia.com/license-manager) to create a license key for your project.
5. Add license key to your project by navigating to ARCamera -> Open Vuforia Engine Configuration -> App License Key
6. To change ImageTarget, create a new database from Vuforia Developer -> Target Manager (https://developer.vuforia.com/targetmanager). Then add a new single image target (whichever image you desired for Vuforia engine to detect and shows the AR 3D object)
  - For more information on ImageTarget, refer to: https://library.vuforia.com/features/images/image-targets.html
8. Build & Run your project in the desired environment (this project was built for iOS). Android Studio may need further set up.

## Usage
1. Users can navigate to the application, enable camera, place ImageTarget where you want to view the AR 3D piano (ImageTarget can be changed, refer to *Set up #6*)
2. Play the AR piano by clicking on the application screen.

Click below to view video demonstration of the AR piano application:


