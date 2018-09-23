Per-Layer Camera Clipping v1.0.2
--------------------------------

-DESCRIPTION-

This asset is intented to let users easily 
set up different far clipping planes for each
layer in their project using distance based culling. This can save resources
in situations where occlusion culling is not 
appropriate and when there are large distance
disparities between objects.

--------------------------------

-SETUP-

The package is pretty easy to implement. 
All you have to do is grab the script 
"ManualCameraClipping" from
Assets/UmbraEvolution/PerLayerCameraClipping/Scripts and drop it
onto the camera that you want to use it on.

--------------------------------

-How-To Guide-

1) Set a default clipping distance.
2) Set the custom distances you want for 
   each layer (they are labled in real
   time for you)
3) Now, when you edit the default distance,
   any layers that have custom values will
   not be affected unless you change their
   values to match up with the default or
   hit the "Reset All to Default button at the bottom