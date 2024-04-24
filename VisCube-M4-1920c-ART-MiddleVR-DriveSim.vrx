<?xml version="1.0" encoding="UTF-8"?>
<MiddleVR>
	<Kernel LogLevel="5" LogInSimulationFolder="1" EnableCrashHandler="1" Version="1.7.3.0" />
	<DeviceManager>
		<Driver Type="vrDriverDirectInput" />
		<Driver Type="vrDriverARTDTrack" LocalPortNumber="5000" FlysticksNb="1" BodyTrackersNb="1" HandTrackersNb="0" TrackerCoordinateSystem="+X|-Z|+Y" />
		<Wand Name="Wand0" Driver="0" Axis="ART.Flystick0.Axis0" HorizontalAxis="0" HorizontalAxisScale="1" VerticalAxis="1" VerticalAxisScale="1" AxisDeadZone="0.3" Buttons="ART.Flystick0.Buttons0" Button0="0" Button1="1" Button2="2" Button3="3" Button4="4" Button5="5" />
	</DeviceManager>
	<DisplayManager Fullscreen="0" AlwaysOnTop="1" WindowBorders="0" ShowMouseCursor="1" VSync="0" GraphicsRenderer="2" AntiAliasing="0" ForceHideTaskbar="0" SaveRenderTarget="0" ChangeWorldScale="0" WorldScale="1">
		<Node3D Name="VRSystemCenterNode" Tag="VRSystemCenter" Parent="None" Tracker="0" IsFiltered="0" Filter="0" PositionLocal="0.000000,0.000000,0.000000" OrientationLocal="0.000000,0.000000,0.000000,1.000000" />
		<Node3D Name="CenterNode" Parent="VRSystemCenterNode" Tracker="0" IsFiltered="0" Filter="0" PositionLocal="0.000000,0.000000,0.000000" OrientationLocal="0.000000,0.000000,0.000000,1.000000" />
		<Node3D Name="HandNode" Tag="Hand" Parent="CenterNode" Tracker="ART.Flystick0.Tracker0" IsFiltered="0" Filter="0" UseTrackerX="1" UseTrackerY="1" UseTrackerZ="1" UseTrackerYaw="1" UseTrackerPitch="1" UseTrackerRoll="1" />
		<Node3D Name="HeadNode" Tag="Head" Parent="CenterNode" Tracker="ART.BodyTracker0" IsFiltered="0" Filter="0" UseTrackerX="1" UseTrackerY="1" UseTrackerZ="1" UseTrackerYaw="1" UseTrackerPitch="1" UseTrackerRoll="1" />
		<CameraStereo Name="CameraCenter" Parent="HeadNode" Tracker="0" IsFiltered="0" Filter="0" PositionLocal="0.000000,0.000000,0.000000" VerticalFOV="60" Near="0.1" Far="30000" Screen="ScreenCenter" ScreenDistance="1" UseViewportAspectRatio="0" AspectRatio="1.6" InterEyeDistance="0.065" LinkConvergence="1" />
		<CameraStereo Name="CameraFloor" Parent="HeadNode" Tracker="0" IsFiltered="0" Filter="0" PositionLocal="0.000000,0.000000,0.000000" VerticalFOV="60" Near="0.1" Far="30000" Screen="ScreenFloor" ScreenDistance="1" UseViewportAspectRatio="0" AspectRatio="1.6" InterEyeDistance="0.065" LinkConvergence="1" />
		<CameraStereo Name="CameraLeft" Parent="HeadNode" Tracker="0" IsFiltered="0" Filter="0" PositionLocal="0.000000,0.000000,0.000000" VerticalFOV="60" Near="0.1" Far="30000" Screen="ScreenLeft" ScreenDistance="1" UseViewportAspectRatio="0" AspectRatio="1.07429" InterEyeDistance="0.065" LinkConvergence="1" />
		<CameraStereo Name="CameraRight" Parent="HeadNode" Tracker="0" IsFiltered="0" Filter="0" PositionLocal="0.000000,0.000000,0.000000" VerticalFOV="60" Near="0.1" Far="30000" Screen="ScreenRight" ScreenDistance="1" UseViewportAspectRatio="0" AspectRatio="1.07429" InterEyeDistance="0.065" LinkConvergence="1" />
		<Screen Name="ScreenCenter" Parent="CenterNode" Tracker="0" IsFiltered="0" Filter="0" PositionLocal="0.000000,1.111250,1.111250" OrientationLocal="0.000000,0.000000,0.000000,1.000000" Width="3.556" Height="2.2225" />
		<Screen Name="ScreenFloor" Parent="CenterNode" Tracker="0" IsFiltered="0" Filter="0" PositionLocal="0.000000,0.000000,0.000000" OrientationLocal="-0.707107,0.000000,0.000000,0.707107" Width="3.556" Height="2.2225" />
		<Screen Name="ScreenLeft" Parent="CenterNode" Tracker="0" IsFiltered="0" Filter="0" PositionLocal="-1.778000,-0.082550,1.111250" OrientationLocal="0.000000,0.000000,0.707107,0.707107" Width="2.3876" Height="2.2225" />
		<Screen Name="ScreenRight" Parent="CenterNode" Tracker="0" IsFiltered="0" Filter="0" PositionLocal="1.778000,-0.082550,1.111250" OrientationLocal="0.000000,-0.000000,-0.707107,0.707107" Width="2.3876" Height="2.2225" />
		<Viewport Name="Center" Left="1920" Top="0" Width="1920" Height="1200" Camera="CameraCenter" Stereo="1" StereoMode="0" CompressSideBySide="0" StereoInvertEyes="0" OculusRiftWarping="0" UseCustomStereoCameras="0" CustomLeftBufferCamera="0" CustomRightBufferCamera="0" OffScreen="0" UseHomography="0" />
		<Viewport Name="Floor" Left="1920" Top="1200" Width="1920" Height="1200" Camera="CameraFloor" Stereo="1" StereoMode="0" CompressSideBySide="0" StereoInvertEyes="0" OculusRiftWarping="0" UseCustomStereoCameras="0" CustomLeftBufferCamera="0" CustomRightBufferCamera="0" OffScreen="0" UseHomography="0" />
		<Viewport Name="Left" Left="2551" Top="2400" Width="1289" Height="1200" Camera="CameraLeft" Stereo="1" StereoMode="0" CompressSideBySide="0" StereoInvertEyes="0" OculusRiftWarping="0" UseCustomStereoCameras="0" CustomLeftBufferCamera="0" CustomRightBufferCamera="0" OffScreen="0" UseHomography="0" />
		<Viewport Name="Right" Left="1920" Top="3600" Width="1289" Height="1200" Camera="CameraRight" Stereo="1" StereoMode="0" CompressSideBySide="0" StereoInvertEyes="0" OculusRiftWarping="0" UseCustomStereoCameras="0" CustomLeftBufferCamera="0" CustomRightBufferCamera="0" OffScreen="0" UseHomography="0" />
	</DisplayManager>
	<ClusterManager NVidiaSwapLock="0" DisableVSyncOnServer="1" ForceOpenGLConversion="0" BigBarrier="0" SimulateClusterLag="0" MultiGPUEnabled="1" ImageDistributionMaxPacketSize="8000" ClientConnectionTimeout="60" />
</MiddleVR>
