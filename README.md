# Unity_Workshop
Unity_Workshop to help with MR devleopment for the Hololens

Scene Configuration

Pre-Requisites:

Windows 10
Windows 10 sdk
Unity 2019.1.71f1 9 recommend download with Unity Hub
	-Include Visual studio, vuforia, and UWP support
Microsoft Mixed Reality Toolkit v2.0.0 RC2 (MRTK)
	-The examples and Foundation packages
Visual Studio 2017
(Optional)Basic Knowledge of Git CMD or A Git UI

Configure Scene:
-Open Unity
-depending on the order of you download the MRTK may have auto loaded into unity you would see it in the project tab under assets if it was there. If not here is the steps to import
In the main asset directory of your project selected go to the top menu and click
	asset>import package>custom package>location of MRTK unity packages on your local 
-Import the unity packages for v2.0.0 release of the MRTK
-open main scene
-Go to file>Build Settings> Platform> Universal Windows Platform(UWP)
-Add open scenes
-Under UWP:
	Target Device Hololens
	X64
	D3D
	Latest
	10.0.10240.0
	Latest
	Latest
	Local Machine
	Release
	Default

-Click switch Platform
-then click Player Settings
	Other Settings:
		-Make sure .NET 4.X is selected
	XR:
	-check VR supported
		-under VR SDK make sure Windows Mixed reality is selected
	-Vuforia Augmented Reality Supported
	- WSA Holographic Remoting Supported
-on the left you should also see under Project Setting>Editor
	- Make sure Version Control Mode is set to “Visible Meta Files”
	-and asset serialization mode is “Force Text”
-Back on the main Screen
-There Should be a menu option MRTK
	>Add to Scene To configure
		>I selected the Default Configuration Profile
-In the Hierarchy you should see MRTK game object and a Mixed Reality Playspace game object.
