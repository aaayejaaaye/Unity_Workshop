<strong>Lesson One Task Instructions:</strong>
</p>
<p>
-[ project window] under Assets right click and create three folders, Scenes, Scripts, and PreFabs.
</p>
<p>
-[ Scenes folder] create a folder named 2019 and create three scenes: 
</p>
<p>
	-go to file >new scene> save as:
</p>
<p>
		-HUD
</p>
<p>
		-Persistent
</p>
<p>
		-TaskHUD
</p>
<p>
-In the to bar menu go to Mixed Reality Toolkit and go to ‘add to scenes and configure( this is new so I picked the default configuration profile for now since it is not really relevant to this session.<strong>(do this for each scene)</strong>
</p>
<p>
- you should now see in the hierarchy a MixedRealityToolkit and MixedRealityPlayspace game objects	. fun new stuff!
</p>
<p>
<strong>Persistent Scene Set Up</strong>
</p>
<p>
-[Hierarchy] right click and create and empty game object-name it ‘Data Controller’
</p>
<p>
-[Project window]>Scripts create a folder ‘Persistent’
</p>
<p>
	-In the folder right click and create 3 new scripts called ‘Data Controller’, ‘Steps’, and ‘Instructions’, ‘InstructionData’
</p>
<p>
-Add the scripts to the correct title name, see comment for further explanation of what each script does. 
</p>
<p>
- [scripts folder] click and drag the ‘DataController.cs’ onto the DataController object in the hierarchy.
</p>
<p>
-Now we are going to add the scenes to the build settings
</p>
<p>
-open build settings and we are going to drag and drop our scene into the 	‘scenes in build’ window. Drop the scenes in this order: Persistent, HUD, and Controller
</p>
<p>
-Save scene
</p>
<p>
<strong>HUD Scene Set Up</strong>
</p>
<p>
-open the HUD scene in the Scene folder
</p>
<p>
-go to the scripts folder and create a new folder called HUD
</p>
<p>
- In HUD create a script called HUDController
</p>
<p>
-Add scripts to HUD Controller
</p>
<p>
- [Hierarchy] create an empty game object and name it ‘HUDController’
</p>
<p>
-drag the HUDController script onto the HUDController game object
</p>
<p>
-right click in the hierarchy: UI>Button
</p>
<p>
-with button selected go to the Inspector
</p>
<p>
- find the OnClick() and select the ‘+’ symbol
</p>
<p>
- select the circle and select the object HUDController(or drag the object into the box)
</p>
<p>
-click ‘No Function and select ‘HUDController’ > ’Start Game()’
</p>
<p>
-In the Hierarchy under button you can change the text to whatever you want. I chose “Open Task Instruction HUD”
</p>
<p>
- Save your HUD Scene
</p>
<p>
<strong>Task HUD Scene Setup</strong>
</p>
<p>
<strong>	</strong>
</p>
<p>
- [Scripts folder] we are going to create a new folder and name it ‘TaskHUD’
</p>
<p>
- now go to the hierarchy and right click, go to UI>Panel
</p>
<p>
- you should see a semi opaque white rectangle
</p>
<p>
- [Inspector] under RectTransform go ahead and adjust the width and height to you liking. I choose 500X300. It helps to open the game view to be able to see how it will look in game proportions.
</p>
<p>
-under image component I picked a bluish color and made it semi opaque. 
</p>
<p>
-I named this panel ‘Instruction Panel’
</p>
<p>
- [Hierarchy] right click ‘Instruction Panel’>UI>Text name this new Text object Instruction display
</p>
<p>
-[Rect Transform] hold alt and stretch the text object across the panel object(go over difference of anchors and rect)
</p>
<p>
-create instruction display Text object
</p>
<p>
-Create stepPanel: delete Image component; add vertical layout group component
</p>
<p>
-prev Next and MAINHUD button optional
</p>
<p>
- under step panel create a Text object name it ‘Step’
</p>
<p>
-[Hierarchy] create GO called Task Pool
</p>
<p>
	-create simpleobjectPool.cs and place it into TaskPoolobject
</p>
<p>
-Create empty GO and name it TaskHUDController
</p>
<p>
-[step object] create a script called ‘StepsText’ add that
</p>
<p>
	-drag StepsText into Steps GO
</p>
<p>
	-add Step GO and drag into StepsText Script script into inspector
</p>
<p>

    -drag the Step GO into the prefab folder and delete from Hierarchy
</p>
<p>
-[GameController Script] see comments
</p>
<p>
- rig the GameController
</p>
<p>
<strong>Creating and Editor</strong>
</p>
<p>
-[assets] create two folders: StreamingAssets and Editor
</p>
<p>
-[Editor] add a script called ‘GameDataEditor’
</p>
<p>
-[Persistent] add GameData script
</p>
<p>
	Serializable object of InstructonData.cs
</p>
<p>
-
</p>
<p>
	
</p>