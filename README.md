# ec500-MusicApp
Final project for EC500 A2 spring 2021

**AR Piano App**
This project was created with Unity 2020.3.5f1 and Vuforia Engine 9.8

## Set up
1. Follow [this link](https://unity3d.com/get-unity/download) to download Unity
2. Follow [this link](https://developer.vuforia.com/downloads/sdk) to add Vuforia to your Unity project
3. Add ARcamera and ImageTarget by navigating to GameObject -> Vuforia Engine -> ARCamera / ImageTarget
4. To use Vuforia engine, create a Vuforia Developer account then go to [Vuforia developer](https://developer.vuforia.com/license-manager) to create a license key for your project.
5. Add license key to your project by navigating to ARCamera -> Open Vuforia Engine Configuration -> App License Key
6. To change ImageTarget, create a new database from Vuforia Developer -> [Target Manager](https://developer.vuforia.com/targetmanager). Then add a new single image target (whichever image you desired for Vuforia engine to detect and shows the AR 3D object)
  - For more information on ImageTarget, refer to: https://library.vuforia.com/features/images/image-targets.html
8. Build & Run your project in the desired environment (this project was built for iOS). Android Studio may need further set up.

NOTE: piano sounds were from [Freesound](https://freesound.org/)

## Usage
1. Users can navigate to the application, enable camera, place ImageTarget where you want to view the AR 3D piano (In this demo, this 
[ImageTarget](https://github.com/primnp/ec500-MusicApp/blob/main/piano.jpg) was used. ImageTarget can be changed, refer to *Set up #6*)
2. Play the AR piano by clicking on the application screen.

Please refer to video below to view demonstration of the assignment. Click to view video.

[![IMAGE ALT TEXT](http://img.youtube.com/vi/3rYEJfa-v64/0.jpg)](http://www.youtube.com/watch?v=3rYEJfa-v64 "EC500 Final Project")


## Improvements
* Create animation when user press a piano key
* Possibly add more piano keys to the app



