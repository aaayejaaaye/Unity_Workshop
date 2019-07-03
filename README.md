**Lesson One Task Instructions:**

-[ project window] under Assets right click and create three folders, Scenes, Scripts, and PreFabs.

-[ Scenes folder] create a folder named 2019 and create three scenes: 

	-go to file >new scene> save as:

		-HUD

		-Persistent

		-TaskHUD

-In the to bar menu go to Mixed Reality Toolkit and go to ‘add to scenes and configure( this is new so I picked the default configuration profile for now since it is not really relevant to this session.**(do this for each scene)**

- you should now see in the hierarchy a MixedRealityToolkit and MixedRealityPlayspace game objects	. fun new stuff!

**Persistent Scene Set Up**

-[Hierarchy] right click and create and empty game object-name it ‘Data Controller’

-[Project window]>Scripts create a folder ‘Persistent’

	-In the folder right click and create 3 new scripts called ‘Data Controller’, ‘Steps’, and ‘Instructions’, ‘InstructionData’

-Add the scripts to the correct title name, see comment for further explanation of what each script does. 

- [scripts folder] click and drag the ‘DataController.cs’ onto the DataController object in the hierarchy.

-Now we are going to add the scenes to the build settings

-open build settings and we are going to drag and drop our scene into the 	‘scenes in build’ window. Drop the scenes in this order: Persistent, HUD, and Controller

-Save scene

**HUD Scene Set Up**

-open the HUD scene in the Scene folder

-go to the scripts folder and create a new folder called HUD

- In HUD create a script called HUDController

-Add scripts to HUD Controller

- [Hierarchy] create an empty game object and name it ‘HUDController’

-drag the HUDController script onto the HUDController game object

-right click in the hierarchy: UI>Button

-with button selected go to the Inspector

- find the OnClick() and select the ‘+’ symbol

- select the circle and select the object HUDController(or drag the object into the box)

-click ‘No Function and select ‘HUDController’ > ’Start Game()’

-In the Hierarchy under button you can change the text to whatever you want. I chose “Open Task Instruction HUD”

- Save your HUD Scene

**Task HUD Scene Setup**

**	**

- [Scripts folder] we are going to create a new folder and name it ‘TaskHUD’

- now go to the hierarchy and right click, go to UI>Panel

- you should see a semi opaque white rectangle

- [Inspector] under RectTransform go ahead and adjust the width and height to you liking. I choose 500X300. It helps to open the game view to be able to see how it will look in game proportions.

-under image component I picked a bluish color and made it semi opaque. 

-I named this panel ‘Instruction Panel’

- [Hierarchy] right click ‘Instruction Panel’>UI>Text name this new Text object Instruction display

-[Rect Transform] hold alt and stretch the text object across the panel object(go over difference of anchors and rect)

-create instruction display Text object

-Create stepPanel: delete Image component; add vertical layout group component

-prev Next and MAINHUD button optional

- under step panel create a Text object name it ‘Step’

-[Hierarchy] create GO called Task Pool

	-create simpleobjectPool.cs and place it into TaskPoolobject

-Create empty GO and name it TaskHUDController

-[step object] create a script called ‘StepsText’ add that

	-drag StepsText into Steps GO

	-add Step GO and drag into StepsText Script script into inspector


    -drag the Step GO into the prefab folder and delete from Hierarchy

-[GameController Script] see comments

- rig the GameController

	


<!-- Docs to Markdown version 1.0β17 -->
