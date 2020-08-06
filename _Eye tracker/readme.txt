(c) 2019 VIOSO GmbH

This is an eyepoint provider .dll and an eye-tracker simulator.
You can enable dynamic eye point for every software using VIOSO warper implementing getViewClip or getViewProj and serve it with a 3D .vwf.
See VIOSOWarpBlend documentation.
Your program will now listen to a specified port on UDP protocoll. A package has a simple format. It is a space ('\x20') separated list of floating point numbers, rotation in euler-angles and degree:
x-position y-position z-position x-rotation y-rotation z-rotation
i.e.
1.72541 0.01200 0.00000 0.00000 11.0448 0.00000

You can also broadcast this to all clients and synchronize outputs, given that they show the same scene.

For x64 software using VIOSOWarpBlend64.dll and listen to UDP port 999:
* Place EyePointProvider64.dll next to VIOSOWarpBlend64.dll
* Set in VIOSOWarpBlend.ini:
EyePointProvider=EyePointProvider64.dll
EyePointProviderParam=listen 999

For x86 software using VIOSOWarpBlend.dll and listen to UDP port 999:
* Place EyePointProvider.dll next to VIOSOWarpBlend.dll
* Set in VIOSOWarpBlend.ini:
EyePointProvider=EyePointProvider.dll
EyePointProviderParam=listen 999

For a simple test, you can specify:
EyePointProviderParam=sinewave
This will undulate all axis and angles in a loop.
