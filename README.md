# demo01-menu
Sample menu and game

Documentation: http://docs.unity3d.com/Manual/UISystem.html

### Notes

**Screen Space - Overlay**

This render mode places UI elements on the screen rendered on top of the scene. If the screen is resized or changes resolution, the Canvas will automatically change size to match this.

**Screen Space - Camera**

This is similar to Screen Space - Overlay, but in this render mode, the Canvas is placed a given distance in front of a specified Camera. The UI elements are rendered by this camera, which means that the Camera settings affect the appearance of the UI. If the Camera is set to Perspective, the UI elements will be rendered with perspective, and the amount of perspective distortion can be controlled by the Camera Field of View. If the screen is resized or changes resolution, or the camera frustrum changes, the Canvas will automatically change size to match as well.

**World Space**

In this render mode, the Canvas will behave as any other object in the scene. The size of the Canvas can be set manually using its Rect Transform, and UI elements will render in front of or behind other objects in the scene based on 3D placement. This is useful for UIs that are meant to be a part of the world. This is also known as a “diegetic interface”.

**Instantiating the UI element**

Prefabs of UI elements are instantiated as normal using the Instantiate method. When setting the parent of the instantiated UI element, it’s recommended to do it using the Transform.SetParent method with the worldPositionStays parameter set to false.

Add Scenes to "Scenes in Build" through File > Build Settings (drag to list)

[ExecuteInEditMode] allows you to run scripts in edit mode