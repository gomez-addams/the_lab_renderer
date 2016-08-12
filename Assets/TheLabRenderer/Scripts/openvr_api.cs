// Copyright (c) Valve Corporation, All rights reserved. ======================
//
// Purpose: This file contains C#/managed code bindings for the OpenVR interfaces
// This file is auto-generated, do not edit it.
//
//=============================================================================

using System;
using System.Runtime.InteropServices;

#if !UNITY_WSA
using Valve.VRRenderingPackage;

namespace Valve.VRRenderingPackage
{

[StructLayout(LayoutKind.Sequential)]
public struct IVRSystem
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _GetRecommendedRenderTargetSize(ref uint pnWidth, ref uint pnHeight);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetRecommendedRenderTargetSize GetRecommendedRenderTargetSize;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate HmdMatrix44_t _GetProjectionMatrix(EVREye eEye, float fNearZ, float fFarZ, EGraphicsAPIConvention eProjType);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetProjectionMatrix GetProjectionMatrix;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _GetProjectionRaw(EVREye eEye, ref float pfLeft, ref float pfRight, ref float pfTop, ref float pfBottom);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetProjectionRaw GetProjectionRaw;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate DistortionCoordinates_t _ComputeDistortion(EVREye eEye, float fU, float fV);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ComputeDistortion ComputeDistortion;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate HmdMatrix34_t _GetEyeToHeadTransform(EVREye eEye);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetEyeToHeadTransform GetEyeToHeadTransform;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetTimeSinceLastVsync(ref float pfSecondsSinceLastVsync, ref ulong pulFrameCounter);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetTimeSinceLastVsync GetTimeSinceLastVsync;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate int _GetD3D9AdapterIndex();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetD3D9AdapterIndex GetD3D9AdapterIndex;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _GetDXGIOutputInfo(ref int pnAdapterIndex);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetDXGIOutputInfo GetDXGIOutputInfo;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _IsDisplayOnDesktop();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _IsDisplayOnDesktop IsDisplayOnDesktop;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _SetDisplayVisibility(bool bIsVisibleOnDesktop);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetDisplayVisibility SetDisplayVisibility;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _GetDeviceToAbsoluteTrackingPose(ETrackingUniverseOrigin eOrigin, float fPredictedSecondsToPhotonsFromNow, [In, Out] TrackedDevicePose_t[] pTrackedDevicePoseArray, uint unTrackedDevicePoseArrayCount);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetDeviceToAbsoluteTrackingPose GetDeviceToAbsoluteTrackingPose;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _ResetSeatedZeroPose();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ResetSeatedZeroPose ResetSeatedZeroPose;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate HmdMatrix34_t _GetSeatedZeroPoseToStandingAbsoluteTrackingPose();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetSeatedZeroPoseToStandingAbsoluteTrackingPose GetSeatedZeroPoseToStandingAbsoluteTrackingPose;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate HmdMatrix34_t _GetRawZeroPoseToStandingAbsoluteTrackingPose();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetRawZeroPoseToStandingAbsoluteTrackingPose GetRawZeroPoseToStandingAbsoluteTrackingPose;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetSortedTrackedDeviceIndicesOfClass(ETrackedDeviceClass eTrackedDeviceClass, [In, Out] uint[] punTrackedDeviceIndexArray, uint unTrackedDeviceIndexArrayCount, uint unRelativeToTrackedDeviceIndex);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetSortedTrackedDeviceIndicesOfClass GetSortedTrackedDeviceIndicesOfClass;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EDeviceActivityLevel _GetTrackedDeviceActivityLevel(uint unDeviceId);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetTrackedDeviceActivityLevel GetTrackedDeviceActivityLevel;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _ApplyTransform(ref TrackedDevicePose_t pOutputPose, ref TrackedDevicePose_t pTrackedDevicePose, ref HmdMatrix34_t pTransform);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ApplyTransform ApplyTransform;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetTrackedDeviceIndexForControllerRole(ETrackedControllerRole unDeviceType);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetTrackedDeviceIndexForControllerRole GetTrackedDeviceIndexForControllerRole;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate ETrackedControllerRole _GetControllerRoleForTrackedDeviceIndex(uint unDeviceIndex);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetControllerRoleForTrackedDeviceIndex GetControllerRoleForTrackedDeviceIndex;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate ETrackedDeviceClass _GetTrackedDeviceClass(uint unDeviceIndex);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetTrackedDeviceClass GetTrackedDeviceClass;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _IsTrackedDeviceConnected(uint unDeviceIndex);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _IsTrackedDeviceConnected IsTrackedDeviceConnected;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetBoolTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetBoolTrackedDeviceProperty GetBoolTrackedDeviceProperty;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate float _GetFloatTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetFloatTrackedDeviceProperty GetFloatTrackedDeviceProperty;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate int _GetInt32TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetInt32TrackedDeviceProperty GetInt32TrackedDeviceProperty;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate ulong _GetUint64TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetUint64TrackedDeviceProperty GetUint64TrackedDeviceProperty;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate HmdMatrix34_t _GetMatrix34TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetMatrix34TrackedDeviceProperty GetMatrix34TrackedDeviceProperty;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetStringTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, System.Text.StringBuilder pchValue, uint unBufferSize, ref ETrackedPropertyError pError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetStringTrackedDeviceProperty GetStringTrackedDeviceProperty;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate IntPtr _GetPropErrorNameFromEnum(ETrackedPropertyError error);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetPropErrorNameFromEnum GetPropErrorNameFromEnum;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _PollNextEvent(ref VREvent_t pEvent, uint uncbVREvent);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _PollNextEvent PollNextEvent;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _PollNextEventWithPose(ETrackingUniverseOrigin eOrigin, ref VREvent_t pEvent, uint uncbVREvent, ref TrackedDevicePose_t pTrackedDevicePose);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _PollNextEventWithPose PollNextEventWithPose;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate IntPtr _GetEventTypeNameFromEnum(EVREventType eType);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetEventTypeNameFromEnum GetEventTypeNameFromEnum;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate HiddenAreaMesh_t _GetHiddenAreaMesh(EVREye eEye);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetHiddenAreaMesh GetHiddenAreaMesh;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetControllerState(uint unControllerDeviceIndex, ref VRControllerState_t pControllerState);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetControllerState GetControllerState;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetControllerStateWithPose(ETrackingUniverseOrigin eOrigin, uint unControllerDeviceIndex, ref VRControllerState_t pControllerState, ref TrackedDevicePose_t pTrackedDevicePose);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetControllerStateWithPose GetControllerStateWithPose;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _TriggerHapticPulse(uint unControllerDeviceIndex, uint unAxisId, char usDurationMicroSec);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _TriggerHapticPulse TriggerHapticPulse;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate IntPtr _GetButtonIdNameFromEnum(EVRButtonId eButtonId);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetButtonIdNameFromEnum GetButtonIdNameFromEnum;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate IntPtr _GetControllerAxisTypeNameFromEnum(EVRControllerAxisType eAxisType);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetControllerAxisTypeNameFromEnum GetControllerAxisTypeNameFromEnum;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _CaptureInputFocus();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _CaptureInputFocus CaptureInputFocus;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _ReleaseInputFocus();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ReleaseInputFocus ReleaseInputFocus;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _IsInputFocusCapturedByAnotherProcess();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _IsInputFocusCapturedByAnotherProcess IsInputFocusCapturedByAnotherProcess;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _DriverDebugRequest(uint unDeviceIndex, string pchRequest, string pchResponseBuffer, uint unResponseBufferSize);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _DriverDebugRequest DriverDebugRequest;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRFirmwareError _PerformFirmwareUpdate(uint unDeviceIndex);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _PerformFirmwareUpdate PerformFirmwareUpdate;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _AcknowledgeQuit_Exiting();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _AcknowledgeQuit_Exiting AcknowledgeQuit_Exiting;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _AcknowledgeQuit_UserPrompt();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _AcknowledgeQuit_UserPrompt AcknowledgeQuit_UserPrompt;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _PerformanceTestEnableCapture(bool bEnable);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _PerformanceTestEnableCapture PerformanceTestEnableCapture;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _PerformanceTestReportFidelityLevelChange(int nFidelityLevel);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _PerformanceTestReportFidelityLevelChange PerformanceTestReportFidelityLevelChange;

}

[StructLayout(LayoutKind.Sequential)]
public struct IVRExtendedDisplay
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _GetWindowBounds(ref int pnX, ref int pnY, ref uint pnWidth, ref uint pnHeight);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetWindowBounds GetWindowBounds;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _GetEyeOutputViewport(EVREye eEye, ref uint pnX, ref uint pnY, ref uint pnWidth, ref uint pnHeight);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetEyeOutputViewport GetEyeOutputViewport;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _GetDXGIOutputInfo(ref int pnAdapterIndex, ref int pnAdapterOutputIndex);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetDXGIOutputInfo GetDXGIOutputInfo;

}

[StructLayout(LayoutKind.Sequential)]
public struct IVRApplications
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _AddApplicationManifest(string pchApplicationManifestFullPath, bool bTemporary);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _AddApplicationManifest AddApplicationManifest;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _RemoveApplicationManifest(string pchApplicationManifestFullPath);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _RemoveApplicationManifest RemoveApplicationManifest;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _IsApplicationInstalled(string pchAppKey);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _IsApplicationInstalled IsApplicationInstalled;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetApplicationCount();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetApplicationCount GetApplicationCount;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _GetApplicationKeyByIndex(uint unApplicationIndex, string pchAppKeyBuffer, uint unAppKeyBufferLen);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetApplicationKeyByIndex GetApplicationKeyByIndex;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _GetApplicationKeyByProcessId(uint unProcessId, string pchAppKeyBuffer, uint unAppKeyBufferLen);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetApplicationKeyByProcessId GetApplicationKeyByProcessId;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _LaunchApplication(string pchAppKey);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _LaunchApplication LaunchApplication;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _LaunchDashboardOverlay(string pchAppKey);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _LaunchDashboardOverlay LaunchDashboardOverlay;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _CancelApplicationLaunch(string pchAppKey);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _CancelApplicationLaunch CancelApplicationLaunch;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _IdentifyApplication(uint unProcessId, string pchAppKey);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _IdentifyApplication IdentifyApplication;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetApplicationProcessId(string pchAppKey);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetApplicationProcessId GetApplicationProcessId;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate IntPtr _GetApplicationsErrorNameFromEnum(EVRApplicationError error);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetApplicationsErrorNameFromEnum GetApplicationsErrorNameFromEnum;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetApplicationPropertyString(string pchAppKey, EVRApplicationProperty eProperty, string pchPropertyValueBuffer, uint unPropertyValueBufferLen, ref EVRApplicationError peError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetApplicationPropertyString GetApplicationPropertyString;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetApplicationPropertyBool(string pchAppKey, EVRApplicationProperty eProperty, ref EVRApplicationError peError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetApplicationPropertyBool GetApplicationPropertyBool;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate ulong _GetApplicationPropertyUint64(string pchAppKey, EVRApplicationProperty eProperty, ref EVRApplicationError peError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetApplicationPropertyUint64 GetApplicationPropertyUint64;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _SetApplicationAutoLaunch(string pchAppKey, bool bAutoLaunch);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetApplicationAutoLaunch SetApplicationAutoLaunch;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetApplicationAutoLaunch(string pchAppKey);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetApplicationAutoLaunch GetApplicationAutoLaunch;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _GetStartingApplication(string pchAppKeyBuffer, uint unAppKeyBufferLen);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetStartingApplication GetStartingApplication;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationTransitionState _GetTransitionState();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetTransitionState GetTransitionState;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _PerformApplicationPrelaunchCheck(string pchAppKey);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _PerformApplicationPrelaunchCheck PerformApplicationPrelaunchCheck;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate IntPtr _GetApplicationsTransitionStateNameFromEnum(EVRApplicationTransitionState state);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetApplicationsTransitionStateNameFromEnum GetApplicationsTransitionStateNameFromEnum;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _IsQuitUserPromptRequested();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _IsQuitUserPromptRequested IsQuitUserPromptRequested;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRApplicationError _LaunchInternalProcess(string pchBinaryPath, string pchArguments, string pchWorkingDirectory);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _LaunchInternalProcess LaunchInternalProcess;

}

[StructLayout(LayoutKind.Sequential)]
public struct IVRChaperone
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate ChaperoneCalibrationState _GetCalibrationState();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetCalibrationState GetCalibrationState;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetPlayAreaSize(ref float pSizeX, ref float pSizeZ);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetPlayAreaSize GetPlayAreaSize;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetPlayAreaRect(ref HmdQuad_t rect);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetPlayAreaRect GetPlayAreaRect;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _ReloadInfo();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ReloadInfo ReloadInfo;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetSceneColor(HmdColor_t color);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetSceneColor SetSceneColor;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _GetBoundsColor(ref HmdColor_t pOutputColorArray, int nNumOutputColors, float flCollisionBoundsFadeDistance, ref HmdColor_t pOutputCameraColor);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetBoundsColor GetBoundsColor;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _AreBoundsVisible();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _AreBoundsVisible AreBoundsVisible;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _ForceBoundsVisible(bool bForce);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ForceBoundsVisible ForceBoundsVisible;

}

[StructLayout(LayoutKind.Sequential)]
public struct IVRChaperoneSetup
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _CommitWorkingCopy(EChaperoneConfigFile configFile);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _CommitWorkingCopy CommitWorkingCopy;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _RevertWorkingCopy();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _RevertWorkingCopy RevertWorkingCopy;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetWorkingPlayAreaSize(ref float pSizeX, ref float pSizeZ);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetWorkingPlayAreaSize GetWorkingPlayAreaSize;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetWorkingPlayAreaRect(ref HmdQuad_t rect);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetWorkingPlayAreaRect GetWorkingPlayAreaRect;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetWorkingCollisionBoundsInfo([In, Out] HmdQuad_t[] pQuadsBuffer, ref uint punQuadsCount);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetWorkingCollisionBoundsInfo GetWorkingCollisionBoundsInfo;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetLiveCollisionBoundsInfo([In, Out] HmdQuad_t[] pQuadsBuffer, ref uint punQuadsCount);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetLiveCollisionBoundsInfo GetLiveCollisionBoundsInfo;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetWorkingSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetWorkingSeatedZeroPoseToRawTrackingPose GetWorkingSeatedZeroPoseToRawTrackingPose;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetWorkingStandingZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatStandingZeroPoseToRawTrackingPose);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetWorkingStandingZeroPoseToRawTrackingPose GetWorkingStandingZeroPoseToRawTrackingPose;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetWorkingPlayAreaSize(float sizeX, float sizeZ);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetWorkingPlayAreaSize SetWorkingPlayAreaSize;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetWorkingCollisionBoundsInfo([In, Out] HmdQuad_t[] pQuadsBuffer, uint unQuadsCount);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetWorkingCollisionBoundsInfo SetWorkingCollisionBoundsInfo;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetWorkingSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pMatSeatedZeroPoseToRawTrackingPose);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetWorkingSeatedZeroPoseToRawTrackingPose SetWorkingSeatedZeroPoseToRawTrackingPose;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetWorkingStandingZeroPoseToRawTrackingPose(ref HmdMatrix34_t pMatStandingZeroPoseToRawTrackingPose);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetWorkingStandingZeroPoseToRawTrackingPose SetWorkingStandingZeroPoseToRawTrackingPose;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _ReloadFromDisk(EChaperoneConfigFile configFile);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ReloadFromDisk ReloadFromDisk;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetLiveSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetLiveSeatedZeroPoseToRawTrackingPose GetLiveSeatedZeroPoseToRawTrackingPose;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetWorkingCollisionBoundsTagsInfo([In, Out] byte[] pTagsBuffer, uint unTagCount);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetWorkingCollisionBoundsTagsInfo SetWorkingCollisionBoundsTagsInfo;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetLiveCollisionBoundsTagsInfo([In, Out] byte[] pTagsBuffer, ref uint punTagCount);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetLiveCollisionBoundsTagsInfo GetLiveCollisionBoundsTagsInfo;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _SetWorkingPhysicalBoundsInfo([In, Out] HmdQuad_t[] pQuadsBuffer, uint unQuadsCount);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetWorkingPhysicalBoundsInfo SetWorkingPhysicalBoundsInfo;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetLivePhysicalBoundsInfo([In, Out] HmdQuad_t[] pQuadsBuffer, ref uint punQuadsCount);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetLivePhysicalBoundsInfo GetLivePhysicalBoundsInfo;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _ExportLiveToBuffer(System.Text.StringBuilder pBuffer, ref uint pnBufferLength);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ExportLiveToBuffer ExportLiveToBuffer;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _ImportFromBufferToWorking(string pBuffer, uint nImportFlags);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ImportFromBufferToWorking ImportFromBufferToWorking;

}

[StructLayout(LayoutKind.Sequential)]
public struct IVRCompositor
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetTrackingSpace(ETrackingUniverseOrigin eOrigin);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetTrackingSpace SetTrackingSpace;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate ETrackingUniverseOrigin _GetTrackingSpace();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetTrackingSpace GetTrackingSpace;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRCompositorError _WaitGetPoses([In, Out] TrackedDevicePose_t[] pRenderPoseArray, uint unRenderPoseArrayCount, [In, Out] TrackedDevicePose_t[] pGamePoseArray, uint unGamePoseArrayCount);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _WaitGetPoses WaitGetPoses;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRCompositorError _GetLastPoses([In, Out] TrackedDevicePose_t[] pRenderPoseArray, uint unRenderPoseArrayCount, [In, Out] TrackedDevicePose_t[] pGamePoseArray, uint unGamePoseArrayCount);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetLastPoses GetLastPoses;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRCompositorError _GetLastPoseForTrackedDeviceIndex(uint unDeviceIndex, ref TrackedDevicePose_t pOutputPose, ref TrackedDevicePose_t pOutputGamePose);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetLastPoseForTrackedDeviceIndex GetLastPoseForTrackedDeviceIndex;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRCompositorError _Submit(EVREye eEye, ref Texture_t pTexture, ref VRTextureBounds_t pBounds, EVRSubmitFlags nSubmitFlags);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _Submit Submit;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _ClearLastSubmittedFrame();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ClearLastSubmittedFrame ClearLastSubmittedFrame;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _PostPresentHandoff();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _PostPresentHandoff PostPresentHandoff;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetFrameTiming(ref Compositor_FrameTiming pTiming, uint unFramesAgo);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetFrameTiming GetFrameTiming;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate float _GetFrameTimeRemaining();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetFrameTimeRemaining GetFrameTimeRemaining;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _FadeToColor(float fSeconds, float fRed, float fGreen, float fBlue, float fAlpha, bool bBackground);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _FadeToColor FadeToColor;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _FadeGrid(float fSeconds, bool bFadeIn);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _FadeGrid FadeGrid;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRCompositorError _SetSkyboxOverride([In, Out] Texture_t[] pTextures, uint unTextureCount);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetSkyboxOverride SetSkyboxOverride;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _ClearSkyboxOverride();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ClearSkyboxOverride ClearSkyboxOverride;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _CompositorBringToFront();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _CompositorBringToFront CompositorBringToFront;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _CompositorGoToBack();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _CompositorGoToBack CompositorGoToBack;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _CompositorQuit();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _CompositorQuit CompositorQuit;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _IsFullscreen();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _IsFullscreen IsFullscreen;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetCurrentSceneFocusProcess();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetCurrentSceneFocusProcess GetCurrentSceneFocusProcess;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetLastFrameRenderer();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetLastFrameRenderer GetLastFrameRenderer;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _CanRenderScene();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _CanRenderScene CanRenderScene;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _ShowMirrorWindow();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ShowMirrorWindow ShowMirrorWindow;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _HideMirrorWindow();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _HideMirrorWindow HideMirrorWindow;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _IsMirrorWindowVisible();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _IsMirrorWindowVisible IsMirrorWindowVisible;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _CompositorDumpImages();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _CompositorDumpImages CompositorDumpImages;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _ShouldAppRenderWithLowResources();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ShouldAppRenderWithLowResources ShouldAppRenderWithLowResources;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _ForceInterleavedReprojectionOn(bool bOverride);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ForceInterleavedReprojectionOn ForceInterleavedReprojectionOn;

}

[StructLayout(LayoutKind.Sequential)]
public struct IVROverlay
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _FindOverlay(string pchOverlayKey, ref ulong pOverlayHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _FindOverlay FindOverlay;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _CreateOverlay(string pchOverlayKey, string pchOverlayFriendlyName, ref ulong pOverlayHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _CreateOverlay CreateOverlay;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _DestroyOverlay(ulong ulOverlayHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _DestroyOverlay DestroyOverlay;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetHighQualityOverlay(ulong ulOverlayHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetHighQualityOverlay SetHighQualityOverlay;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate ulong _GetHighQualityOverlay();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetHighQualityOverlay GetHighQualityOverlay;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetOverlayKey(ulong ulOverlayHandle, System.Text.StringBuilder pchValue, uint unBufferSize, ref EVROverlayError pError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayKey GetOverlayKey;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetOverlayName(ulong ulOverlayHandle, System.Text.StringBuilder pchValue, uint unBufferSize, ref EVROverlayError pError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayName GetOverlayName;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayImageData(ulong ulOverlayHandle, IntPtr pvBuffer, uint unBufferSize, ref uint punWidth, ref uint punHeight);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayImageData GetOverlayImageData;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate IntPtr _GetOverlayErrorNameFromEnum(EVROverlayError error);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayErrorNameFromEnum GetOverlayErrorNameFromEnum;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayFlag(ulong ulOverlayHandle, VROverlayFlags eOverlayFlag, bool bEnabled);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayFlag SetOverlayFlag;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayFlag(ulong ulOverlayHandle, VROverlayFlags eOverlayFlag, ref bool pbEnabled);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayFlag GetOverlayFlag;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayColor(ulong ulOverlayHandle, float fRed, float fGreen, float fBlue);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayColor SetOverlayColor;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayColor(ulong ulOverlayHandle, ref float pfRed, ref float pfGreen, ref float pfBlue);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayColor GetOverlayColor;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayAlpha(ulong ulOverlayHandle, float fAlpha);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayAlpha SetOverlayAlpha;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayAlpha(ulong ulOverlayHandle, ref float pfAlpha);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayAlpha GetOverlayAlpha;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayWidthInMeters(ulong ulOverlayHandle, float fWidthInMeters);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayWidthInMeters SetOverlayWidthInMeters;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayWidthInMeters(ulong ulOverlayHandle, ref float pfWidthInMeters);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayWidthInMeters GetOverlayWidthInMeters;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayAutoCurveDistanceRangeInMeters(ulong ulOverlayHandle, float fMinDistanceInMeters, float fMaxDistanceInMeters);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayAutoCurveDistanceRangeInMeters SetOverlayAutoCurveDistanceRangeInMeters;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayAutoCurveDistanceRangeInMeters(ulong ulOverlayHandle, ref float pfMinDistanceInMeters, ref float pfMaxDistanceInMeters);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayAutoCurveDistanceRangeInMeters GetOverlayAutoCurveDistanceRangeInMeters;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayTextureColorSpace(ulong ulOverlayHandle, EColorSpace eTextureColorSpace);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayTextureColorSpace SetOverlayTextureColorSpace;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayTextureColorSpace(ulong ulOverlayHandle, ref EColorSpace peTextureColorSpace);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayTextureColorSpace GetOverlayTextureColorSpace;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayTextureBounds(ulong ulOverlayHandle, ref VRTextureBounds_t pOverlayTextureBounds);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayTextureBounds SetOverlayTextureBounds;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayTextureBounds(ulong ulOverlayHandle, ref VRTextureBounds_t pOverlayTextureBounds);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayTextureBounds GetOverlayTextureBounds;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayTransformType(ulong ulOverlayHandle, ref VROverlayTransformType peTransformType);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayTransformType GetOverlayTransformType;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayTransformAbsolute(ulong ulOverlayHandle, ETrackingUniverseOrigin eTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayTransformAbsolute SetOverlayTransformAbsolute;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayTransformAbsolute(ulong ulOverlayHandle, ref ETrackingUniverseOrigin peTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayTransformAbsolute GetOverlayTransformAbsolute;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayTransformTrackedDeviceRelative(ulong ulOverlayHandle, uint unTrackedDevice, ref HmdMatrix34_t pmatTrackedDeviceToOverlayTransform);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayTransformTrackedDeviceRelative SetOverlayTransformTrackedDeviceRelative;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayTransformTrackedDeviceRelative(ulong ulOverlayHandle, ref uint punTrackedDevice, ref HmdMatrix34_t pmatTrackedDeviceToOverlayTransform);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayTransformTrackedDeviceRelative GetOverlayTransformTrackedDeviceRelative;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayTransformTrackedDeviceComponent(ulong ulOverlayHandle, uint unDeviceIndex, string pchComponentName);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayTransformTrackedDeviceComponent SetOverlayTransformTrackedDeviceComponent;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayTransformTrackedDeviceComponent(ulong ulOverlayHandle, ref uint punDeviceIndex, string pchComponentName, uint unComponentNameSize);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayTransformTrackedDeviceComponent GetOverlayTransformTrackedDeviceComponent;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _ShowOverlay(ulong ulOverlayHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ShowOverlay ShowOverlay;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _HideOverlay(ulong ulOverlayHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _HideOverlay HideOverlay;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _IsOverlayVisible(ulong ulOverlayHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _IsOverlayVisible IsOverlayVisible;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetTransformForOverlayCoordinates(ulong ulOverlayHandle, ETrackingUniverseOrigin eTrackingOrigin, HmdVector2_t coordinatesInOverlay, ref HmdMatrix34_t pmatTransform);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetTransformForOverlayCoordinates GetTransformForOverlayCoordinates;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _PollNextOverlayEvent(ulong ulOverlayHandle, ref VREvent_t pEvent, uint uncbVREvent);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _PollNextOverlayEvent PollNextOverlayEvent;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayInputMethod(ulong ulOverlayHandle, ref VROverlayInputMethod peInputMethod);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayInputMethod GetOverlayInputMethod;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayInputMethod(ulong ulOverlayHandle, VROverlayInputMethod eInputMethod);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayInputMethod SetOverlayInputMethod;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetOverlayMouseScale(ulong ulOverlayHandle, ref HmdVector2_t pvecMouseScale);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetOverlayMouseScale GetOverlayMouseScale;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayMouseScale(ulong ulOverlayHandle, ref HmdVector2_t pvecMouseScale);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayMouseScale SetOverlayMouseScale;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _ComputeOverlayIntersection(ulong ulOverlayHandle, ref VROverlayIntersectionParams_t pParams, ref VROverlayIntersectionResults_t pResults);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ComputeOverlayIntersection ComputeOverlayIntersection;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _HandleControllerOverlayInteractionAsMouse(ulong ulOverlayHandle, uint unControllerDeviceIndex);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _HandleControllerOverlayInteractionAsMouse HandleControllerOverlayInteractionAsMouse;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _IsHoverTargetOverlay(ulong ulOverlayHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _IsHoverTargetOverlay IsHoverTargetOverlay;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate ulong _GetGamepadFocusOverlay();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetGamepadFocusOverlay GetGamepadFocusOverlay;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetGamepadFocusOverlay(ulong ulNewFocusOverlay);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetGamepadFocusOverlay SetGamepadFocusOverlay;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayNeighbor(EOverlayDirection eDirection, ulong ulFrom, ulong ulTo);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayNeighbor SetOverlayNeighbor;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _MoveGamepadFocusToNeighbor(EOverlayDirection eDirection, ulong ulFrom);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _MoveGamepadFocusToNeighbor MoveGamepadFocusToNeighbor;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayTexture(ulong ulOverlayHandle, ref Texture_t pTexture);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayTexture SetOverlayTexture;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _ClearOverlayTexture(ulong ulOverlayHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ClearOverlayTexture ClearOverlayTexture;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayRaw(ulong ulOverlayHandle, IntPtr pvBuffer, uint unWidth, uint unHeight, uint unDepth);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayRaw SetOverlayRaw;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetOverlayFromFile(ulong ulOverlayHandle, string pchFilePath);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetOverlayFromFile SetOverlayFromFile;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _CreateDashboardOverlay(string pchOverlayKey, string pchOverlayFriendlyName, ref ulong pMainHandle, ref ulong pThumbnailHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _CreateDashboardOverlay CreateDashboardOverlay;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _IsDashboardVisible();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _IsDashboardVisible IsDashboardVisible;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _IsActiveDashboardOverlay(ulong ulOverlayHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _IsActiveDashboardOverlay IsActiveDashboardOverlay;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _SetDashboardOverlaySceneProcess(ulong ulOverlayHandle, uint unProcessId);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetDashboardOverlaySceneProcess SetDashboardOverlaySceneProcess;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _GetDashboardOverlaySceneProcess(ulong ulOverlayHandle, ref uint punProcessId);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetDashboardOverlaySceneProcess GetDashboardOverlaySceneProcess;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _ShowDashboard(string pchOverlayToShow);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ShowDashboard ShowDashboard;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetPrimaryDashboardDevice();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetPrimaryDashboardDevice GetPrimaryDashboardDevice;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _ShowKeyboard(int eInputMode, int eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText, bool bUseMinimalMode, ulong uUserValue);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ShowKeyboard ShowKeyboard;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVROverlayError _ShowKeyboardForOverlay(ulong ulOverlayHandle, int eInputMode, int eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText, bool bUseMinimalMode, ulong uUserValue);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ShowKeyboardForOverlay ShowKeyboardForOverlay;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetKeyboardText(System.Text.StringBuilder pchText, uint cchText);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetKeyboardText GetKeyboardText;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _HideKeyboard();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _HideKeyboard HideKeyboard;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetKeyboardTransformAbsolute(ETrackingUniverseOrigin eTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToKeyboardTransform);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetKeyboardTransformAbsolute SetKeyboardTransformAbsolute;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetKeyboardPositionForOverlay(ulong ulOverlayHandle, HmdRect2_t avoidRect);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetKeyboardPositionForOverlay SetKeyboardPositionForOverlay;

}

[StructLayout(LayoutKind.Sequential)]
public struct IVRRenderModels
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRRenderModelError _LoadRenderModel_Async(string pchRenderModelName, ref IntPtr ppRenderModel);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _LoadRenderModel_Async LoadRenderModel_Async;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _FreeRenderModel(IntPtr pRenderModel);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _FreeRenderModel FreeRenderModel;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRRenderModelError _LoadTexture_Async(int textureId, ref IntPtr ppTexture);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _LoadTexture_Async LoadTexture_Async;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _FreeTexture(IntPtr pTexture);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _FreeTexture FreeTexture;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRRenderModelError _LoadTextureD3D11_Async(int textureId, IntPtr pD3D11Device, ref IntPtr ppD3D11Texture2D);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _LoadTextureD3D11_Async LoadTextureD3D11_Async;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRRenderModelError _LoadIntoTextureD3D11_Async(int textureId, IntPtr pDstTexture);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _LoadIntoTextureD3D11_Async LoadIntoTextureD3D11_Async;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _FreeTextureD3D11(IntPtr pD3D11Texture2D);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _FreeTextureD3D11 FreeTextureD3D11;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetRenderModelName(uint unRenderModelIndex, System.Text.StringBuilder pchRenderModelName, uint unRenderModelNameLen);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetRenderModelName GetRenderModelName;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetRenderModelCount();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetRenderModelCount GetRenderModelCount;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetComponentCount(string pchRenderModelName);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetComponentCount GetComponentCount;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetComponentName(string pchRenderModelName, uint unComponentIndex, System.Text.StringBuilder pchComponentName, uint unComponentNameLen);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetComponentName GetComponentName;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate ulong _GetComponentButtonMask(string pchRenderModelName, string pchComponentName);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetComponentButtonMask GetComponentButtonMask;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint _GetComponentRenderModelName(string pchRenderModelName, string pchComponentName, System.Text.StringBuilder pchComponentRenderModelName, uint unComponentRenderModelNameLen);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetComponentRenderModelName GetComponentRenderModelName;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetComponentState(string pchRenderModelName, string pchComponentName, ref VRControllerState_t pControllerState, ref RenderModel_ControllerMode_State_t pState, ref RenderModel_ComponentState_t pComponentState);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetComponentState GetComponentState;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _RenderModelHasComponent(string pchRenderModelName, string pchComponentName);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _RenderModelHasComponent RenderModelHasComponent;

}

[StructLayout(LayoutKind.Sequential)]
public struct IVRNotifications
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRNotificationError _CreateNotification(ulong ulOverlayHandle, ulong ulUserValue, EVRNotificationType type, string pchText, EVRNotificationStyle style, ref NotificationBitmap_t pImage, ref uint pNotificationId);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _CreateNotification CreateNotification;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate EVRNotificationError _RemoveNotification(uint notificationId);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _RemoveNotification RemoveNotification;

}

[StructLayout(LayoutKind.Sequential)]
public struct IVRSettings
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate IntPtr _GetSettingsErrorNameFromEnum(EVRSettingsError eError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetSettingsErrorNameFromEnum GetSettingsErrorNameFromEnum;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _Sync(bool bForce, ref EVRSettingsError peError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _Sync Sync;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetBool(string pchSection, string pchSettingsKey, bool bDefaultValue, ref EVRSettingsError peError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetBool GetBool;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetBool(string pchSection, string pchSettingsKey, bool bValue, ref EVRSettingsError peError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetBool SetBool;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate int _GetInt32(string pchSection, string pchSettingsKey, int nDefaultValue, ref EVRSettingsError peError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetInt32 GetInt32;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetInt32(string pchSection, string pchSettingsKey, int nValue, ref EVRSettingsError peError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetInt32 SetInt32;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate float _GetFloat(string pchSection, string pchSettingsKey, float flDefaultValue, ref EVRSettingsError peError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetFloat GetFloat;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetFloat(string pchSection, string pchSettingsKey, float flValue, ref EVRSettingsError peError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetFloat SetFloat;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _GetString(string pchSection, string pchSettingsKey, string pchValue, uint unValueLen, string pchDefaultValue, ref EVRSettingsError peError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetString GetString;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _SetString(string pchSection, string pchSettingsKey, string pchValue, ref EVRSettingsError peError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetString SetString;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _RemoveSection(string pchSection, ref EVRSettingsError peError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _RemoveSection RemoveSection;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _RemoveKeyInSection(string pchSection, string pchSettingsKey, ref EVRSettingsError peError);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _RemoveKeyInSection RemoveKeyInSection;

}

[StructLayout(LayoutKind.Sequential)]
public struct IVRTrackedCamera
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _HasCamera(uint nDeviceIndex);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _HasCamera HasCamera;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetCameraFirmwareDescription(uint nDeviceIndex, string pBuffer, uint nBufferLen);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetCameraFirmwareDescription GetCameraFirmwareDescription;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetCameraFrameDimensions(uint nDeviceIndex, ECameraVideoStreamFormat nVideoStreamFormat, ref uint pWidth, ref uint pHeight);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetCameraFrameDimensions GetCameraFrameDimensions;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _SetCameraVideoStreamFormat(uint nDeviceIndex, ECameraVideoStreamFormat nVideoStreamFormat);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetCameraVideoStreamFormat SetCameraVideoStreamFormat;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate ECameraVideoStreamFormat _GetCameraVideoStreamFormat(uint nDeviceIndex);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetCameraVideoStreamFormat GetCameraVideoStreamFormat;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _EnableCameraForStreaming(uint nDeviceIndex, bool bEnable);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _EnableCameraForStreaming EnableCameraForStreaming;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _StartVideoStream(uint nDeviceIndex);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _StartVideoStream StartVideoStream;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _StopVideoStream(uint nDeviceIndex);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _StopVideoStream StopVideoStream;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _IsVideoStreamActive(uint nDeviceIndex, ref bool pbPaused, ref float pflElapsedTime);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _IsVideoStreamActive IsVideoStreamActive;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate IntPtr _GetVideoStreamFrame(uint nDeviceIndex);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetVideoStreamFrame GetVideoStreamFrame;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _ReleaseVideoStreamFrame(uint nDeviceIndex, ref CameraVideoStreamFrame_t pFrameImage);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ReleaseVideoStreamFrame ReleaseVideoStreamFrame;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _SetAutoExposure(uint nDeviceIndex, bool bEnable);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetAutoExposure SetAutoExposure;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _PauseVideoStream(uint nDeviceIndex);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _PauseVideoStream PauseVideoStream;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _ResumeVideoStream(uint nDeviceIndex);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ResumeVideoStream ResumeVideoStream;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetCameraDistortion(uint nDeviceIndex, float flInputU, float flInputV, ref float pflOutputU, ref float pflOutputV);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetCameraDistortion GetCameraDistortion;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetCameraProjection(uint nDeviceIndex, float flWidthPixels, float flHeightPixels, float flZNear, float flZFar, ref HmdMatrix44_t pProjection);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetCameraProjection GetCameraProjection;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetRecommendedCameraUndistortion(uint nDeviceIndex, ref uint pUndistortionWidthPixels, ref uint pUndistortionHeightPixels);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetRecommendedCameraUndistortion GetRecommendedCameraUndistortion;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _SetCameraUndistortion(uint nDeviceIndex, uint nUndistortionWidthPixels, uint nUndistortionHeightPixels);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _SetCameraUndistortion SetCameraUndistortion;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _RequestVideoServicesForTool();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _RequestVideoServicesForTool RequestVideoServicesForTool;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _ReleaseVideoServicesForTool();
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ReleaseVideoServicesForTool ReleaseVideoServicesForTool;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _GetVideoStreamFrameSharedTextureGL(bool bUndistorted, ref uint pglTextureId, IntPtr pglSharedTextureHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _GetVideoStreamFrameSharedTextureGL GetVideoStreamFrameSharedTextureGL;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate bool _ReleaseVideoStreamFrameSharedTextureGL(uint glTextureId, IntPtr glSharedTextureHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _ReleaseVideoStreamFrameSharedTextureGL ReleaseVideoStreamFrameSharedTextureGL;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _LockSharedTextureGL(IntPtr glSharedTextureHandle, ref CameraVideoStreamFrame_t pFrameImage);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _LockSharedTextureGL LockSharedTextureGL;

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void _UnlockSharedTextureGL(IntPtr glSharedTextureHandle);
	[MarshalAs(UnmanagedType.FunctionPtr)]
	internal _UnlockSharedTextureGL UnlockSharedTextureGL;

}


public class CVRSystem
{
	IVRSystem FnTable;
	internal CVRSystem(IntPtr pInterface)
	{
		FnTable = (IVRSystem)Marshal.PtrToStructure(pInterface, typeof(IVRSystem));
	}
	public void GetRecommendedRenderTargetSize(ref uint pnWidth,ref uint pnHeight)
	{
		pnWidth = 0;
		pnHeight = 0;
		FnTable.GetRecommendedRenderTargetSize(ref pnWidth,ref pnHeight);
	}
	public HmdMatrix44_t GetProjectionMatrix(EVREye eEye,float fNearZ,float fFarZ,EGraphicsAPIConvention eProjType)
	{
		HmdMatrix44_t result = FnTable.GetProjectionMatrix(eEye,fNearZ,fFarZ,eProjType);
		return result;
	}
	public void GetProjectionRaw(EVREye eEye,ref float pfLeft,ref float pfRight,ref float pfTop,ref float pfBottom)
	{
		pfLeft = 0;
		pfRight = 0;
		pfTop = 0;
		pfBottom = 0;
		FnTable.GetProjectionRaw(eEye,ref pfLeft,ref pfRight,ref pfTop,ref pfBottom);
	}
	public DistortionCoordinates_t ComputeDistortion(EVREye eEye,float fU,float fV)
	{
		DistortionCoordinates_t result = FnTable.ComputeDistortion(eEye,fU,fV);
		return result;
	}
	public HmdMatrix34_t GetEyeToHeadTransform(EVREye eEye)
	{
		HmdMatrix34_t result = FnTable.GetEyeToHeadTransform(eEye);
		return result;
	}
	public bool GetTimeSinceLastVsync(ref float pfSecondsSinceLastVsync,ref ulong pulFrameCounter)
	{
		pfSecondsSinceLastVsync = 0;
		pulFrameCounter = 0;
		bool result = FnTable.GetTimeSinceLastVsync(ref pfSecondsSinceLastVsync,ref pulFrameCounter);
		return result;
	}
	public int GetD3D9AdapterIndex()
	{
		int result = FnTable.GetD3D9AdapterIndex();
		return result;
	}
	public void GetDXGIOutputInfo(ref int pnAdapterIndex)
	{
		pnAdapterIndex = 0;
		FnTable.GetDXGIOutputInfo(ref pnAdapterIndex);
	}
	public bool IsDisplayOnDesktop()
	{
		bool result = FnTable.IsDisplayOnDesktop();
		return result;
	}
	public bool SetDisplayVisibility(bool bIsVisibleOnDesktop)
	{
		bool result = FnTable.SetDisplayVisibility(bIsVisibleOnDesktop);
		return result;
	}
	public void GetDeviceToAbsoluteTrackingPose(ETrackingUniverseOrigin eOrigin,float fPredictedSecondsToPhotonsFromNow,TrackedDevicePose_t [] pTrackedDevicePoseArray)
	{
		FnTable.GetDeviceToAbsoluteTrackingPose(eOrigin,fPredictedSecondsToPhotonsFromNow,pTrackedDevicePoseArray,(uint) pTrackedDevicePoseArray.Length);
	}
	public void ResetSeatedZeroPose()
	{
		FnTable.ResetSeatedZeroPose();
	}
	public HmdMatrix34_t GetSeatedZeroPoseToStandingAbsoluteTrackingPose()
	{
		HmdMatrix34_t result = FnTable.GetSeatedZeroPoseToStandingAbsoluteTrackingPose();
		return result;
	}
	public HmdMatrix34_t GetRawZeroPoseToStandingAbsoluteTrackingPose()
	{
		HmdMatrix34_t result = FnTable.GetRawZeroPoseToStandingAbsoluteTrackingPose();
		return result;
	}
	public uint GetSortedTrackedDeviceIndicesOfClass(ETrackedDeviceClass eTrackedDeviceClass,uint [] punTrackedDeviceIndexArray,uint unRelativeToTrackedDeviceIndex)
	{
		uint result = FnTable.GetSortedTrackedDeviceIndicesOfClass(eTrackedDeviceClass,punTrackedDeviceIndexArray,(uint) punTrackedDeviceIndexArray.Length,unRelativeToTrackedDeviceIndex);
		return result;
	}
	public EDeviceActivityLevel GetTrackedDeviceActivityLevel(uint unDeviceId)
	{
		EDeviceActivityLevel result = FnTable.GetTrackedDeviceActivityLevel(unDeviceId);
		return result;
	}
	public void ApplyTransform(ref TrackedDevicePose_t pOutputPose,ref TrackedDevicePose_t pTrackedDevicePose,ref HmdMatrix34_t pTransform)
	{
		FnTable.ApplyTransform(ref pOutputPose,ref pTrackedDevicePose,ref pTransform);
	}
	public uint GetTrackedDeviceIndexForControllerRole(ETrackedControllerRole unDeviceType)
	{
		uint result = FnTable.GetTrackedDeviceIndexForControllerRole(unDeviceType);
		return result;
	}
	public ETrackedControllerRole GetControllerRoleForTrackedDeviceIndex(uint unDeviceIndex)
	{
		ETrackedControllerRole result = FnTable.GetControllerRoleForTrackedDeviceIndex(unDeviceIndex);
		return result;
	}
	public ETrackedDeviceClass GetTrackedDeviceClass(uint unDeviceIndex)
	{
		ETrackedDeviceClass result = FnTable.GetTrackedDeviceClass(unDeviceIndex);
		return result;
	}
	public bool IsTrackedDeviceConnected(uint unDeviceIndex)
	{
		bool result = FnTable.IsTrackedDeviceConnected(unDeviceIndex);
		return result;
	}
	public bool GetBoolTrackedDeviceProperty(uint unDeviceIndex,ETrackedDeviceProperty prop,ref ETrackedPropertyError pError)
	{
		bool result = FnTable.GetBoolTrackedDeviceProperty(unDeviceIndex,prop,ref pError);
		return result;
	}
	public float GetFloatTrackedDeviceProperty(uint unDeviceIndex,ETrackedDeviceProperty prop,ref ETrackedPropertyError pError)
	{
		float result = FnTable.GetFloatTrackedDeviceProperty(unDeviceIndex,prop,ref pError);
		return result;
	}
	public int GetInt32TrackedDeviceProperty(uint unDeviceIndex,ETrackedDeviceProperty prop,ref ETrackedPropertyError pError)
	{
		int result = FnTable.GetInt32TrackedDeviceProperty(unDeviceIndex,prop,ref pError);
		return result;
	}
	public ulong GetUint64TrackedDeviceProperty(uint unDeviceIndex,ETrackedDeviceProperty prop,ref ETrackedPropertyError pError)
	{
		ulong result = FnTable.GetUint64TrackedDeviceProperty(unDeviceIndex,prop,ref pError);
		return result;
	}
	public HmdMatrix34_t GetMatrix34TrackedDeviceProperty(uint unDeviceIndex,ETrackedDeviceProperty prop,ref ETrackedPropertyError pError)
	{
		HmdMatrix34_t result = FnTable.GetMatrix34TrackedDeviceProperty(unDeviceIndex,prop,ref pError);
		return result;
	}
	public uint GetStringTrackedDeviceProperty(uint unDeviceIndex,ETrackedDeviceProperty prop,System.Text.StringBuilder pchValue,uint unBufferSize,ref ETrackedPropertyError pError)
	{
		uint result = FnTable.GetStringTrackedDeviceProperty(unDeviceIndex,prop,pchValue,unBufferSize,ref pError);
		return result;
	}
	public string GetPropErrorNameFromEnum(ETrackedPropertyError error)
	{
		IntPtr result = FnTable.GetPropErrorNameFromEnum(error);
		return (string) Marshal.PtrToStructure(result, typeof(string));
	}
	public bool PollNextEvent(ref VREvent_t pEvent,uint uncbVREvent)
	{
		bool result = FnTable.PollNextEvent(ref pEvent,uncbVREvent);
		return result;
	}
	public bool PollNextEventWithPose(ETrackingUniverseOrigin eOrigin,ref VREvent_t pEvent,uint uncbVREvent,ref TrackedDevicePose_t pTrackedDevicePose)
	{
		bool result = FnTable.PollNextEventWithPose(eOrigin,ref pEvent,uncbVREvent,ref pTrackedDevicePose);
		return result;
	}
	public string GetEventTypeNameFromEnum(EVREventType eType)
	{
		IntPtr result = FnTable.GetEventTypeNameFromEnum(eType);
		return (string) Marshal.PtrToStructure(result, typeof(string));
	}
	public HiddenAreaMesh_t GetHiddenAreaMesh(EVREye eEye)
	{
		HiddenAreaMesh_t result = FnTable.GetHiddenAreaMesh(eEye);
		return result;
	}
	public bool GetControllerState(uint unControllerDeviceIndex,ref VRControllerState_t pControllerState)
	{
		bool result = FnTable.GetControllerState(unControllerDeviceIndex,ref pControllerState);
		return result;
	}
	public bool GetControllerStateWithPose(ETrackingUniverseOrigin eOrigin,uint unControllerDeviceIndex,ref VRControllerState_t pControllerState,ref TrackedDevicePose_t pTrackedDevicePose)
	{
		bool result = FnTable.GetControllerStateWithPose(eOrigin,unControllerDeviceIndex,ref pControllerState,ref pTrackedDevicePose);
		return result;
	}
	public void TriggerHapticPulse(uint unControllerDeviceIndex,uint unAxisId,char usDurationMicroSec)
	{
		FnTable.TriggerHapticPulse(unControllerDeviceIndex,unAxisId,usDurationMicroSec);
	}
	public string GetButtonIdNameFromEnum(EVRButtonId eButtonId)
	{
		IntPtr result = FnTable.GetButtonIdNameFromEnum(eButtonId);
		return (string) Marshal.PtrToStructure(result, typeof(string));
	}
	public string GetControllerAxisTypeNameFromEnum(EVRControllerAxisType eAxisType)
	{
		IntPtr result = FnTable.GetControllerAxisTypeNameFromEnum(eAxisType);
		return (string) Marshal.PtrToStructure(result, typeof(string));
	}
	public bool CaptureInputFocus()
	{
		bool result = FnTable.CaptureInputFocus();
		return result;
	}
	public void ReleaseInputFocus()
	{
		FnTable.ReleaseInputFocus();
	}
	public bool IsInputFocusCapturedByAnotherProcess()
	{
		bool result = FnTable.IsInputFocusCapturedByAnotherProcess();
		return result;
	}
	public uint DriverDebugRequest(uint unDeviceIndex,string pchRequest,string pchResponseBuffer,uint unResponseBufferSize)
	{
		uint result = FnTable.DriverDebugRequest(unDeviceIndex,pchRequest,pchResponseBuffer,unResponseBufferSize);
		return result;
	}
	public EVRFirmwareError PerformFirmwareUpdate(uint unDeviceIndex)
	{
		EVRFirmwareError result = FnTable.PerformFirmwareUpdate(unDeviceIndex);
		return result;
	}
	public void AcknowledgeQuit_Exiting()
	{
		FnTable.AcknowledgeQuit_Exiting();
	}
	public void AcknowledgeQuit_UserPrompt()
	{
		FnTable.AcknowledgeQuit_UserPrompt();
	}
	public void PerformanceTestEnableCapture(bool bEnable)
	{
		FnTable.PerformanceTestEnableCapture(bEnable);
	}
	public void PerformanceTestReportFidelityLevelChange(int nFidelityLevel)
	{
		FnTable.PerformanceTestReportFidelityLevelChange(nFidelityLevel);
	}
}


public class CVRExtendedDisplay
{
	IVRExtendedDisplay FnTable;
	internal CVRExtendedDisplay(IntPtr pInterface)
	{
		FnTable = (IVRExtendedDisplay)Marshal.PtrToStructure(pInterface, typeof(IVRExtendedDisplay));
	}
	public void GetWindowBounds(ref int pnX,ref int pnY,ref uint pnWidth,ref uint pnHeight)
	{
		pnX = 0;
		pnY = 0;
		pnWidth = 0;
		pnHeight = 0;
		FnTable.GetWindowBounds(ref pnX,ref pnY,ref pnWidth,ref pnHeight);
	}
	public void GetEyeOutputViewport(EVREye eEye,ref uint pnX,ref uint pnY,ref uint pnWidth,ref uint pnHeight)
	{
		pnX = 0;
		pnY = 0;
		pnWidth = 0;
		pnHeight = 0;
		FnTable.GetEyeOutputViewport(eEye,ref pnX,ref pnY,ref pnWidth,ref pnHeight);
	}
	public void GetDXGIOutputInfo(ref int pnAdapterIndex,ref int pnAdapterOutputIndex)
	{
		pnAdapterIndex = 0;
		pnAdapterOutputIndex = 0;
		FnTable.GetDXGIOutputInfo(ref pnAdapterIndex,ref pnAdapterOutputIndex);
	}
}


public class CVRApplications
{
	IVRApplications FnTable;
	internal CVRApplications(IntPtr pInterface)
	{
		FnTable = (IVRApplications)Marshal.PtrToStructure(pInterface, typeof(IVRApplications));
	}
	public EVRApplicationError AddApplicationManifest(string pchApplicationManifestFullPath,bool bTemporary)
	{
		EVRApplicationError result = FnTable.AddApplicationManifest(pchApplicationManifestFullPath,bTemporary);
		return result;
	}
	public EVRApplicationError RemoveApplicationManifest(string pchApplicationManifestFullPath)
	{
		EVRApplicationError result = FnTable.RemoveApplicationManifest(pchApplicationManifestFullPath);
		return result;
	}
	public bool IsApplicationInstalled(string pchAppKey)
	{
		bool result = FnTable.IsApplicationInstalled(pchAppKey);
		return result;
	}
	public uint GetApplicationCount()
	{
		uint result = FnTable.GetApplicationCount();
		return result;
	}
	public EVRApplicationError GetApplicationKeyByIndex(uint unApplicationIndex,string pchAppKeyBuffer,uint unAppKeyBufferLen)
	{
		EVRApplicationError result = FnTable.GetApplicationKeyByIndex(unApplicationIndex,pchAppKeyBuffer,unAppKeyBufferLen);
		return result;
	}
	public EVRApplicationError GetApplicationKeyByProcessId(uint unProcessId,string pchAppKeyBuffer,uint unAppKeyBufferLen)
	{
		EVRApplicationError result = FnTable.GetApplicationKeyByProcessId(unProcessId,pchAppKeyBuffer,unAppKeyBufferLen);
		return result;
	}
	public EVRApplicationError LaunchApplication(string pchAppKey)
	{
		EVRApplicationError result = FnTable.LaunchApplication(pchAppKey);
		return result;
	}
	public EVRApplicationError LaunchDashboardOverlay(string pchAppKey)
	{
		EVRApplicationError result = FnTable.LaunchDashboardOverlay(pchAppKey);
		return result;
	}
	public bool CancelApplicationLaunch(string pchAppKey)
	{
		bool result = FnTable.CancelApplicationLaunch(pchAppKey);
		return result;
	}
	public EVRApplicationError IdentifyApplication(uint unProcessId,string pchAppKey)
	{
		EVRApplicationError result = FnTable.IdentifyApplication(unProcessId,pchAppKey);
		return result;
	}
	public uint GetApplicationProcessId(string pchAppKey)
	{
		uint result = FnTable.GetApplicationProcessId(pchAppKey);
		return result;
	}
	public string GetApplicationsErrorNameFromEnum(EVRApplicationError error)
	{
		IntPtr result = FnTable.GetApplicationsErrorNameFromEnum(error);
		return (string) Marshal.PtrToStructure(result, typeof(string));
	}
	public uint GetApplicationPropertyString(string pchAppKey,EVRApplicationProperty eProperty,string pchPropertyValueBuffer,uint unPropertyValueBufferLen,ref EVRApplicationError peError)
	{
		uint result = FnTable.GetApplicationPropertyString(pchAppKey,eProperty,pchPropertyValueBuffer,unPropertyValueBufferLen,ref peError);
		return result;
	}
	public bool GetApplicationPropertyBool(string pchAppKey,EVRApplicationProperty eProperty,ref EVRApplicationError peError)
	{
		bool result = FnTable.GetApplicationPropertyBool(pchAppKey,eProperty,ref peError);
		return result;
	}
	public ulong GetApplicationPropertyUint64(string pchAppKey,EVRApplicationProperty eProperty,ref EVRApplicationError peError)
	{
		ulong result = FnTable.GetApplicationPropertyUint64(pchAppKey,eProperty,ref peError);
		return result;
	}
	public EVRApplicationError SetApplicationAutoLaunch(string pchAppKey,bool bAutoLaunch)
	{
		EVRApplicationError result = FnTable.SetApplicationAutoLaunch(pchAppKey,bAutoLaunch);
		return result;
	}
	public bool GetApplicationAutoLaunch(string pchAppKey)
	{
		bool result = FnTable.GetApplicationAutoLaunch(pchAppKey);
		return result;
	}
	public EVRApplicationError GetStartingApplication(string pchAppKeyBuffer,uint unAppKeyBufferLen)
	{
		EVRApplicationError result = FnTable.GetStartingApplication(pchAppKeyBuffer,unAppKeyBufferLen);
		return result;
	}
	public EVRApplicationTransitionState GetTransitionState()
	{
		EVRApplicationTransitionState result = FnTable.GetTransitionState();
		return result;
	}
	public EVRApplicationError PerformApplicationPrelaunchCheck(string pchAppKey)
	{
		EVRApplicationError result = FnTable.PerformApplicationPrelaunchCheck(pchAppKey);
		return result;
	}
	public string GetApplicationsTransitionStateNameFromEnum(EVRApplicationTransitionState state)
	{
		IntPtr result = FnTable.GetApplicationsTransitionStateNameFromEnum(state);
		return (string) Marshal.PtrToStructure(result, typeof(string));
	}
	public bool IsQuitUserPromptRequested()
	{
		bool result = FnTable.IsQuitUserPromptRequested();
		return result;
	}
	public EVRApplicationError LaunchInternalProcess(string pchBinaryPath,string pchArguments,string pchWorkingDirectory)
	{
		EVRApplicationError result = FnTable.LaunchInternalProcess(pchBinaryPath,pchArguments,pchWorkingDirectory);
		return result;
	}
}


public class CVRChaperone
{
	IVRChaperone FnTable;
	internal CVRChaperone(IntPtr pInterface)
	{
		FnTable = (IVRChaperone)Marshal.PtrToStructure(pInterface, typeof(IVRChaperone));
	}
	public ChaperoneCalibrationState GetCalibrationState()
	{
		ChaperoneCalibrationState result = FnTable.GetCalibrationState();
		return result;
	}
	public bool GetPlayAreaSize(ref float pSizeX,ref float pSizeZ)
	{
		pSizeX = 0;
		pSizeZ = 0;
		bool result = FnTable.GetPlayAreaSize(ref pSizeX,ref pSizeZ);
		return result;
	}
	public bool GetPlayAreaRect(ref HmdQuad_t rect)
	{
		bool result = FnTable.GetPlayAreaRect(ref rect);
		return result;
	}
	public void ReloadInfo()
	{
		FnTable.ReloadInfo();
	}
	public void SetSceneColor(HmdColor_t color)
	{
		FnTable.SetSceneColor(color);
	}
	public void GetBoundsColor(ref HmdColor_t pOutputColorArray,int nNumOutputColors,float flCollisionBoundsFadeDistance,ref HmdColor_t pOutputCameraColor)
	{
		FnTable.GetBoundsColor(ref pOutputColorArray,nNumOutputColors,flCollisionBoundsFadeDistance,ref pOutputCameraColor);
	}
	public bool AreBoundsVisible()
	{
		bool result = FnTable.AreBoundsVisible();
		return result;
	}
	public void ForceBoundsVisible(bool bForce)
	{
		FnTable.ForceBoundsVisible(bForce);
	}
}


public class CVRChaperoneSetup
{
	IVRChaperoneSetup FnTable;
	internal CVRChaperoneSetup(IntPtr pInterface)
	{
		FnTable = (IVRChaperoneSetup)Marshal.PtrToStructure(pInterface, typeof(IVRChaperoneSetup));
	}
	public bool CommitWorkingCopy(EChaperoneConfigFile configFile)
	{
		bool result = FnTable.CommitWorkingCopy(configFile);
		return result;
	}
	public void RevertWorkingCopy()
	{
		FnTable.RevertWorkingCopy();
	}
	public bool GetWorkingPlayAreaSize(ref float pSizeX,ref float pSizeZ)
	{
		pSizeX = 0;
		pSizeZ = 0;
		bool result = FnTable.GetWorkingPlayAreaSize(ref pSizeX,ref pSizeZ);
		return result;
	}
	public bool GetWorkingPlayAreaRect(ref HmdQuad_t rect)
	{
		bool result = FnTable.GetWorkingPlayAreaRect(ref rect);
		return result;
	}
	public bool GetWorkingCollisionBoundsInfo(out HmdQuad_t [] pQuadsBuffer)
	{
		uint punQuadsCount = 0;
		bool result = FnTable.GetWorkingCollisionBoundsInfo(null,ref punQuadsCount);
		pQuadsBuffer= new HmdQuad_t[punQuadsCount];
		result = FnTable.GetWorkingCollisionBoundsInfo(pQuadsBuffer,ref punQuadsCount);
		return result;
	}
	public bool GetLiveCollisionBoundsInfo(out HmdQuad_t [] pQuadsBuffer)
	{
		uint punQuadsCount = 0;
		bool result = FnTable.GetLiveCollisionBoundsInfo(null,ref punQuadsCount);
		pQuadsBuffer= new HmdQuad_t[punQuadsCount];
		result = FnTable.GetLiveCollisionBoundsInfo(pQuadsBuffer,ref punQuadsCount);
		return result;
	}
	public bool GetWorkingSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose)
	{
		bool result = FnTable.GetWorkingSeatedZeroPoseToRawTrackingPose(ref pmatSeatedZeroPoseToRawTrackingPose);
		return result;
	}
	public bool GetWorkingStandingZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatStandingZeroPoseToRawTrackingPose)
	{
		bool result = FnTable.GetWorkingStandingZeroPoseToRawTrackingPose(ref pmatStandingZeroPoseToRawTrackingPose);
		return result;
	}
	public void SetWorkingPlayAreaSize(float sizeX,float sizeZ)
	{
		FnTable.SetWorkingPlayAreaSize(sizeX,sizeZ);
	}
	public void SetWorkingCollisionBoundsInfo(HmdQuad_t [] pQuadsBuffer)
	{
		FnTable.SetWorkingCollisionBoundsInfo(pQuadsBuffer,(uint) pQuadsBuffer.Length);
	}
	public void SetWorkingSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pMatSeatedZeroPoseToRawTrackingPose)
	{
		FnTable.SetWorkingSeatedZeroPoseToRawTrackingPose(ref pMatSeatedZeroPoseToRawTrackingPose);
	}
	public void SetWorkingStandingZeroPoseToRawTrackingPose(ref HmdMatrix34_t pMatStandingZeroPoseToRawTrackingPose)
	{
		FnTable.SetWorkingStandingZeroPoseToRawTrackingPose(ref pMatStandingZeroPoseToRawTrackingPose);
	}
	public void ReloadFromDisk(EChaperoneConfigFile configFile)
	{
		FnTable.ReloadFromDisk(configFile);
	}
	public bool GetLiveSeatedZeroPoseToRawTrackingPose(ref HmdMatrix34_t pmatSeatedZeroPoseToRawTrackingPose)
	{
		bool result = FnTable.GetLiveSeatedZeroPoseToRawTrackingPose(ref pmatSeatedZeroPoseToRawTrackingPose);
		return result;
	}
	public void SetWorkingCollisionBoundsTagsInfo(byte [] pTagsBuffer)
	{
		FnTable.SetWorkingCollisionBoundsTagsInfo(pTagsBuffer,(uint) pTagsBuffer.Length);
	}
	public bool GetLiveCollisionBoundsTagsInfo(out byte [] pTagsBuffer)
	{
		uint punTagCount = 0;
		bool result = FnTable.GetLiveCollisionBoundsTagsInfo(null,ref punTagCount);
		pTagsBuffer= new byte[punTagCount];
		result = FnTable.GetLiveCollisionBoundsTagsInfo(pTagsBuffer,ref punTagCount);
		return result;
	}
	public bool SetWorkingPhysicalBoundsInfo(HmdQuad_t [] pQuadsBuffer)
	{
		bool result = FnTable.SetWorkingPhysicalBoundsInfo(pQuadsBuffer,(uint) pQuadsBuffer.Length);
		return result;
	}
	public bool GetLivePhysicalBoundsInfo(out HmdQuad_t [] pQuadsBuffer)
	{
		uint punQuadsCount = 0;
		bool result = FnTable.GetLivePhysicalBoundsInfo(null,ref punQuadsCount);
		pQuadsBuffer= new HmdQuad_t[punQuadsCount];
		result = FnTable.GetLivePhysicalBoundsInfo(pQuadsBuffer,ref punQuadsCount);
		return result;
	}
	public bool ExportLiveToBuffer(System.Text.StringBuilder pBuffer,ref uint pnBufferLength)
	{
		pnBufferLength = 0;
		bool result = FnTable.ExportLiveToBuffer(pBuffer,ref pnBufferLength);
		return result;
	}
	public bool ImportFromBufferToWorking(string pBuffer,uint nImportFlags)
	{
		bool result = FnTable.ImportFromBufferToWorking(pBuffer,nImportFlags);
		return result;
	}
}


public class CVRCompositor
{
	IVRCompositor FnTable;
	internal CVRCompositor(IntPtr pInterface)
	{
		FnTable = (IVRCompositor)Marshal.PtrToStructure(pInterface, typeof(IVRCompositor));
	}
	public void SetTrackingSpace(ETrackingUniverseOrigin eOrigin)
	{
		FnTable.SetTrackingSpace(eOrigin);
	}
	public ETrackingUniverseOrigin GetTrackingSpace()
	{
		ETrackingUniverseOrigin result = FnTable.GetTrackingSpace();
		return result;
	}
	public EVRCompositorError WaitGetPoses(TrackedDevicePose_t [] pRenderPoseArray,TrackedDevicePose_t [] pGamePoseArray)
	{
		EVRCompositorError result = FnTable.WaitGetPoses(pRenderPoseArray,(uint) pRenderPoseArray.Length,pGamePoseArray,(uint) pGamePoseArray.Length);
		return result;
	}
	public EVRCompositorError GetLastPoses(TrackedDevicePose_t [] pRenderPoseArray,TrackedDevicePose_t [] pGamePoseArray)
	{
		EVRCompositorError result = FnTable.GetLastPoses(pRenderPoseArray,(uint) pRenderPoseArray.Length,pGamePoseArray,(uint) pGamePoseArray.Length);
		return result;
	}
	public EVRCompositorError GetLastPoseForTrackedDeviceIndex(uint unDeviceIndex,ref TrackedDevicePose_t pOutputPose,ref TrackedDevicePose_t pOutputGamePose)
	{
		EVRCompositorError result = FnTable.GetLastPoseForTrackedDeviceIndex(unDeviceIndex,ref pOutputPose,ref pOutputGamePose);
		return result;
	}
	public EVRCompositorError Submit(EVREye eEye,ref Texture_t pTexture,ref VRTextureBounds_t pBounds,EVRSubmitFlags nSubmitFlags)
	{
		EVRCompositorError result = FnTable.Submit(eEye,ref pTexture,ref pBounds,nSubmitFlags);
		return result;
	}
	public void ClearLastSubmittedFrame()
	{
		FnTable.ClearLastSubmittedFrame();
	}
	public void PostPresentHandoff()
	{
		FnTable.PostPresentHandoff();
	}
	public bool GetFrameTiming(ref Compositor_FrameTiming pTiming,uint unFramesAgo)
	{
		bool result = FnTable.GetFrameTiming(ref pTiming,unFramesAgo);
		return result;
	}
	public float GetFrameTimeRemaining()
	{
		float result = FnTable.GetFrameTimeRemaining();
		return result;
	}
	public void FadeToColor(float fSeconds,float fRed,float fGreen,float fBlue,float fAlpha,bool bBackground)
	{
		FnTable.FadeToColor(fSeconds,fRed,fGreen,fBlue,fAlpha,bBackground);
	}
	public void FadeGrid(float fSeconds,bool bFadeIn)
	{
		FnTable.FadeGrid(fSeconds,bFadeIn);
	}
	public EVRCompositorError SetSkyboxOverride(Texture_t [] pTextures)
	{
		EVRCompositorError result = FnTable.SetSkyboxOverride(pTextures,(uint) pTextures.Length);
		return result;
	}
	public void ClearSkyboxOverride()
	{
		FnTable.ClearSkyboxOverride();
	}
	public void CompositorBringToFront()
	{
		FnTable.CompositorBringToFront();
	}
	public void CompositorGoToBack()
	{
		FnTable.CompositorGoToBack();
	}
	public void CompositorQuit()
	{
		FnTable.CompositorQuit();
	}
	public bool IsFullscreen()
	{
		bool result = FnTable.IsFullscreen();
		return result;
	}
	public uint GetCurrentSceneFocusProcess()
	{
		uint result = FnTable.GetCurrentSceneFocusProcess();
		return result;
	}
	public uint GetLastFrameRenderer()
	{
		uint result = FnTable.GetLastFrameRenderer();
		return result;
	}
	public bool CanRenderScene()
	{
		bool result = FnTable.CanRenderScene();
		return result;
	}
	public void ShowMirrorWindow()
	{
		FnTable.ShowMirrorWindow();
	}
	public void HideMirrorWindow()
	{
		FnTable.HideMirrorWindow();
	}
	public bool IsMirrorWindowVisible()
	{
		bool result = FnTable.IsMirrorWindowVisible();
		return result;
	}
	public void CompositorDumpImages()
	{
		FnTable.CompositorDumpImages();
	}
	public bool ShouldAppRenderWithLowResources()
	{
		bool result = FnTable.ShouldAppRenderWithLowResources();
		return result;
	}
	public void ForceInterleavedReprojectionOn(bool bOverride)
	{
		FnTable.ForceInterleavedReprojectionOn(bOverride);
	}
}


public class CVROverlay
{
	IVROverlay FnTable;
	internal CVROverlay(IntPtr pInterface)
	{
		FnTable = (IVROverlay)Marshal.PtrToStructure(pInterface, typeof(IVROverlay));
	}
	public EVROverlayError FindOverlay(string pchOverlayKey,ref ulong pOverlayHandle)
	{
		pOverlayHandle = 0;
		EVROverlayError result = FnTable.FindOverlay(pchOverlayKey,ref pOverlayHandle);
		return result;
	}
	public EVROverlayError CreateOverlay(string pchOverlayKey,string pchOverlayFriendlyName,ref ulong pOverlayHandle)
	{
		pOverlayHandle = 0;
		EVROverlayError result = FnTable.CreateOverlay(pchOverlayKey,pchOverlayFriendlyName,ref pOverlayHandle);
		return result;
	}
	public EVROverlayError DestroyOverlay(ulong ulOverlayHandle)
	{
		EVROverlayError result = FnTable.DestroyOverlay(ulOverlayHandle);
		return result;
	}
	public EVROverlayError SetHighQualityOverlay(ulong ulOverlayHandle)
	{
		EVROverlayError result = FnTable.SetHighQualityOverlay(ulOverlayHandle);
		return result;
	}
	public ulong GetHighQualityOverlay()
	{
		ulong result = FnTable.GetHighQualityOverlay();
		return result;
	}
	public uint GetOverlayKey(ulong ulOverlayHandle,System.Text.StringBuilder pchValue,uint unBufferSize,ref EVROverlayError pError)
	{
		uint result = FnTable.GetOverlayKey(ulOverlayHandle,pchValue,unBufferSize,ref pError);
		return result;
	}
	public uint GetOverlayName(ulong ulOverlayHandle,System.Text.StringBuilder pchValue,uint unBufferSize,ref EVROverlayError pError)
	{
		uint result = FnTable.GetOverlayName(ulOverlayHandle,pchValue,unBufferSize,ref pError);
		return result;
	}
	public EVROverlayError GetOverlayImageData(ulong ulOverlayHandle,IntPtr pvBuffer,uint unBufferSize,ref uint punWidth,ref uint punHeight)
	{
		punWidth = 0;
		punHeight = 0;
		EVROverlayError result = FnTable.GetOverlayImageData(ulOverlayHandle,pvBuffer,unBufferSize,ref punWidth,ref punHeight);
		return result;
	}
	public string GetOverlayErrorNameFromEnum(EVROverlayError error)
	{
		IntPtr result = FnTable.GetOverlayErrorNameFromEnum(error);
		return (string) Marshal.PtrToStructure(result, typeof(string));
	}
	public EVROverlayError SetOverlayFlag(ulong ulOverlayHandle,VROverlayFlags eOverlayFlag,bool bEnabled)
	{
		EVROverlayError result = FnTable.SetOverlayFlag(ulOverlayHandle,eOverlayFlag,bEnabled);
		return result;
	}
	public EVROverlayError GetOverlayFlag(ulong ulOverlayHandle,VROverlayFlags eOverlayFlag,ref bool pbEnabled)
	{
		pbEnabled = false;
		EVROverlayError result = FnTable.GetOverlayFlag(ulOverlayHandle,eOverlayFlag,ref pbEnabled);
		return result;
	}
	public EVROverlayError SetOverlayColor(ulong ulOverlayHandle,float fRed,float fGreen,float fBlue)
	{
		EVROverlayError result = FnTable.SetOverlayColor(ulOverlayHandle,fRed,fGreen,fBlue);
		return result;
	}
	public EVROverlayError GetOverlayColor(ulong ulOverlayHandle,ref float pfRed,ref float pfGreen,ref float pfBlue)
	{
		pfRed = 0;
		pfGreen = 0;
		pfBlue = 0;
		EVROverlayError result = FnTable.GetOverlayColor(ulOverlayHandle,ref pfRed,ref pfGreen,ref pfBlue);
		return result;
	}
	public EVROverlayError SetOverlayAlpha(ulong ulOverlayHandle,float fAlpha)
	{
		EVROverlayError result = FnTable.SetOverlayAlpha(ulOverlayHandle,fAlpha);
		return result;
	}
	public EVROverlayError GetOverlayAlpha(ulong ulOverlayHandle,ref float pfAlpha)
	{
		pfAlpha = 0;
		EVROverlayError result = FnTable.GetOverlayAlpha(ulOverlayHandle,ref pfAlpha);
		return result;
	}
	public EVROverlayError SetOverlayWidthInMeters(ulong ulOverlayHandle,float fWidthInMeters)
	{
		EVROverlayError result = FnTable.SetOverlayWidthInMeters(ulOverlayHandle,fWidthInMeters);
		return result;
	}
	public EVROverlayError GetOverlayWidthInMeters(ulong ulOverlayHandle,ref float pfWidthInMeters)
	{
		pfWidthInMeters = 0;
		EVROverlayError result = FnTable.GetOverlayWidthInMeters(ulOverlayHandle,ref pfWidthInMeters);
		return result;
	}
	public EVROverlayError SetOverlayAutoCurveDistanceRangeInMeters(ulong ulOverlayHandle,float fMinDistanceInMeters,float fMaxDistanceInMeters)
	{
		EVROverlayError result = FnTable.SetOverlayAutoCurveDistanceRangeInMeters(ulOverlayHandle,fMinDistanceInMeters,fMaxDistanceInMeters);
		return result;
	}
	public EVROverlayError GetOverlayAutoCurveDistanceRangeInMeters(ulong ulOverlayHandle,ref float pfMinDistanceInMeters,ref float pfMaxDistanceInMeters)
	{
		pfMinDistanceInMeters = 0;
		pfMaxDistanceInMeters = 0;
		EVROverlayError result = FnTable.GetOverlayAutoCurveDistanceRangeInMeters(ulOverlayHandle,ref pfMinDistanceInMeters,ref pfMaxDistanceInMeters);
		return result;
	}
	public EVROverlayError SetOverlayTextureColorSpace(ulong ulOverlayHandle,EColorSpace eTextureColorSpace)
	{
		EVROverlayError result = FnTable.SetOverlayTextureColorSpace(ulOverlayHandle,eTextureColorSpace);
		return result;
	}
	public EVROverlayError GetOverlayTextureColorSpace(ulong ulOverlayHandle,ref EColorSpace peTextureColorSpace)
	{
		EVROverlayError result = FnTable.GetOverlayTextureColorSpace(ulOverlayHandle,ref peTextureColorSpace);
		return result;
	}
	public EVROverlayError SetOverlayTextureBounds(ulong ulOverlayHandle,ref VRTextureBounds_t pOverlayTextureBounds)
	{
		EVROverlayError result = FnTable.SetOverlayTextureBounds(ulOverlayHandle,ref pOverlayTextureBounds);
		return result;
	}
	public EVROverlayError GetOverlayTextureBounds(ulong ulOverlayHandle,ref VRTextureBounds_t pOverlayTextureBounds)
	{
		EVROverlayError result = FnTable.GetOverlayTextureBounds(ulOverlayHandle,ref pOverlayTextureBounds);
		return result;
	}
	public EVROverlayError GetOverlayTransformType(ulong ulOverlayHandle,ref VROverlayTransformType peTransformType)
	{
		EVROverlayError result = FnTable.GetOverlayTransformType(ulOverlayHandle,ref peTransformType);
		return result;
	}
	public EVROverlayError SetOverlayTransformAbsolute(ulong ulOverlayHandle,ETrackingUniverseOrigin eTrackingOrigin,ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform)
	{
		EVROverlayError result = FnTable.SetOverlayTransformAbsolute(ulOverlayHandle,eTrackingOrigin,ref pmatTrackingOriginToOverlayTransform);
		return result;
	}
	public EVROverlayError GetOverlayTransformAbsolute(ulong ulOverlayHandle,ref ETrackingUniverseOrigin peTrackingOrigin,ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform)
	{
		EVROverlayError result = FnTable.GetOverlayTransformAbsolute(ulOverlayHandle,ref peTrackingOrigin,ref pmatTrackingOriginToOverlayTransform);
		return result;
	}
	public EVROverlayError SetOverlayTransformTrackedDeviceRelative(ulong ulOverlayHandle,uint unTrackedDevice,ref HmdMatrix34_t pmatTrackedDeviceToOverlayTransform)
	{
		EVROverlayError result = FnTable.SetOverlayTransformTrackedDeviceRelative(ulOverlayHandle,unTrackedDevice,ref pmatTrackedDeviceToOverlayTransform);
		return result;
	}
	public EVROverlayError GetOverlayTransformTrackedDeviceRelative(ulong ulOverlayHandle,ref uint punTrackedDevice,ref HmdMatrix34_t pmatTrackedDeviceToOverlayTransform)
	{
		punTrackedDevice = 0;
		EVROverlayError result = FnTable.GetOverlayTransformTrackedDeviceRelative(ulOverlayHandle,ref punTrackedDevice,ref pmatTrackedDeviceToOverlayTransform);
		return result;
	}
	public EVROverlayError SetOverlayTransformTrackedDeviceComponent(ulong ulOverlayHandle,uint unDeviceIndex,string pchComponentName)
	{
		EVROverlayError result = FnTable.SetOverlayTransformTrackedDeviceComponent(ulOverlayHandle,unDeviceIndex,pchComponentName);
		return result;
	}
	public EVROverlayError GetOverlayTransformTrackedDeviceComponent(ulong ulOverlayHandle,ref uint punDeviceIndex,string pchComponentName,uint unComponentNameSize)
	{
		punDeviceIndex = 0;
		EVROverlayError result = FnTable.GetOverlayTransformTrackedDeviceComponent(ulOverlayHandle,ref punDeviceIndex,pchComponentName,unComponentNameSize);
		return result;
	}
	public EVROverlayError ShowOverlay(ulong ulOverlayHandle)
	{
		EVROverlayError result = FnTable.ShowOverlay(ulOverlayHandle);
		return result;
	}
	public EVROverlayError HideOverlay(ulong ulOverlayHandle)
	{
		EVROverlayError result = FnTable.HideOverlay(ulOverlayHandle);
		return result;
	}
	public bool IsOverlayVisible(ulong ulOverlayHandle)
	{
		bool result = FnTable.IsOverlayVisible(ulOverlayHandle);
		return result;
	}
	public EVROverlayError GetTransformForOverlayCoordinates(ulong ulOverlayHandle,ETrackingUniverseOrigin eTrackingOrigin,HmdVector2_t coordinatesInOverlay,ref HmdMatrix34_t pmatTransform)
	{
		EVROverlayError result = FnTable.GetTransformForOverlayCoordinates(ulOverlayHandle,eTrackingOrigin,coordinatesInOverlay,ref pmatTransform);
		return result;
	}
	public bool PollNextOverlayEvent(ulong ulOverlayHandle,ref VREvent_t pEvent,uint uncbVREvent)
	{
		bool result = FnTable.PollNextOverlayEvent(ulOverlayHandle,ref pEvent,uncbVREvent);
		return result;
	}
	public EVROverlayError GetOverlayInputMethod(ulong ulOverlayHandle,ref VROverlayInputMethod peInputMethod)
	{
		EVROverlayError result = FnTable.GetOverlayInputMethod(ulOverlayHandle,ref peInputMethod);
		return result;
	}
	public EVROverlayError SetOverlayInputMethod(ulong ulOverlayHandle,VROverlayInputMethod eInputMethod)
	{
		EVROverlayError result = FnTable.SetOverlayInputMethod(ulOverlayHandle,eInputMethod);
		return result;
	}
	public EVROverlayError GetOverlayMouseScale(ulong ulOverlayHandle,ref HmdVector2_t pvecMouseScale)
	{
		EVROverlayError result = FnTable.GetOverlayMouseScale(ulOverlayHandle,ref pvecMouseScale);
		return result;
	}
	public EVROverlayError SetOverlayMouseScale(ulong ulOverlayHandle,ref HmdVector2_t pvecMouseScale)
	{
		EVROverlayError result = FnTable.SetOverlayMouseScale(ulOverlayHandle,ref pvecMouseScale);
		return result;
	}
	public bool ComputeOverlayIntersection(ulong ulOverlayHandle,ref VROverlayIntersectionParams_t pParams,ref VROverlayIntersectionResults_t pResults)
	{
		bool result = FnTable.ComputeOverlayIntersection(ulOverlayHandle,ref pParams,ref pResults);
		return result;
	}
	public bool HandleControllerOverlayInteractionAsMouse(ulong ulOverlayHandle,uint unControllerDeviceIndex)
	{
		bool result = FnTable.HandleControllerOverlayInteractionAsMouse(ulOverlayHandle,unControllerDeviceIndex);
		return result;
	}
	public bool IsHoverTargetOverlay(ulong ulOverlayHandle)
	{
		bool result = FnTable.IsHoverTargetOverlay(ulOverlayHandle);
		return result;
	}
	public ulong GetGamepadFocusOverlay()
	{
		ulong result = FnTable.GetGamepadFocusOverlay();
		return result;
	}
	public EVROverlayError SetGamepadFocusOverlay(ulong ulNewFocusOverlay)
	{
		EVROverlayError result = FnTable.SetGamepadFocusOverlay(ulNewFocusOverlay);
		return result;
	}
	public EVROverlayError SetOverlayNeighbor(EOverlayDirection eDirection,ulong ulFrom,ulong ulTo)
	{
		EVROverlayError result = FnTable.SetOverlayNeighbor(eDirection,ulFrom,ulTo);
		return result;
	}
	public EVROverlayError MoveGamepadFocusToNeighbor(EOverlayDirection eDirection,ulong ulFrom)
	{
		EVROverlayError result = FnTable.MoveGamepadFocusToNeighbor(eDirection,ulFrom);
		return result;
	}
	public EVROverlayError SetOverlayTexture(ulong ulOverlayHandle,ref Texture_t pTexture)
	{
		EVROverlayError result = FnTable.SetOverlayTexture(ulOverlayHandle,ref pTexture);
		return result;
	}
	public EVROverlayError ClearOverlayTexture(ulong ulOverlayHandle)
	{
		EVROverlayError result = FnTable.ClearOverlayTexture(ulOverlayHandle);
		return result;
	}
	public EVROverlayError SetOverlayRaw(ulong ulOverlayHandle,IntPtr pvBuffer,uint unWidth,uint unHeight,uint unDepth)
	{
		EVROverlayError result = FnTable.SetOverlayRaw(ulOverlayHandle,pvBuffer,unWidth,unHeight,unDepth);
		return result;
	}
	public EVROverlayError SetOverlayFromFile(ulong ulOverlayHandle,string pchFilePath)
	{
		EVROverlayError result = FnTable.SetOverlayFromFile(ulOverlayHandle,pchFilePath);
		return result;
	}
	public EVROverlayError CreateDashboardOverlay(string pchOverlayKey,string pchOverlayFriendlyName,ref ulong pMainHandle,ref ulong pThumbnailHandle)
	{
		pMainHandle = 0;
		pThumbnailHandle = 0;
		EVROverlayError result = FnTable.CreateDashboardOverlay(pchOverlayKey,pchOverlayFriendlyName,ref pMainHandle,ref pThumbnailHandle);
		return result;
	}
	public bool IsDashboardVisible()
	{
		bool result = FnTable.IsDashboardVisible();
		return result;
	}
	public bool IsActiveDashboardOverlay(ulong ulOverlayHandle)
	{
		bool result = FnTable.IsActiveDashboardOverlay(ulOverlayHandle);
		return result;
	}
	public EVROverlayError SetDashboardOverlaySceneProcess(ulong ulOverlayHandle,uint unProcessId)
	{
		EVROverlayError result = FnTable.SetDashboardOverlaySceneProcess(ulOverlayHandle,unProcessId);
		return result;
	}
	public EVROverlayError GetDashboardOverlaySceneProcess(ulong ulOverlayHandle,ref uint punProcessId)
	{
		punProcessId = 0;
		EVROverlayError result = FnTable.GetDashboardOverlaySceneProcess(ulOverlayHandle,ref punProcessId);
		return result;
	}
	public void ShowDashboard(string pchOverlayToShow)
	{
		FnTable.ShowDashboard(pchOverlayToShow);
	}
	public uint GetPrimaryDashboardDevice()
	{
		uint result = FnTable.GetPrimaryDashboardDevice();
		return result;
	}
	public EVROverlayError ShowKeyboard(int eInputMode,int eLineInputMode,string pchDescription,uint unCharMax,string pchExistingText,bool bUseMinimalMode,ulong uUserValue)
	{
		EVROverlayError result = FnTable.ShowKeyboard(eInputMode,eLineInputMode,pchDescription,unCharMax,pchExistingText,bUseMinimalMode,uUserValue);
		return result;
	}
	public EVROverlayError ShowKeyboardForOverlay(ulong ulOverlayHandle,int eInputMode,int eLineInputMode,string pchDescription,uint unCharMax,string pchExistingText,bool bUseMinimalMode,ulong uUserValue)
	{
		EVROverlayError result = FnTable.ShowKeyboardForOverlay(ulOverlayHandle,eInputMode,eLineInputMode,pchDescription,unCharMax,pchExistingText,bUseMinimalMode,uUserValue);
		return result;
	}
	public uint GetKeyboardText(System.Text.StringBuilder pchText,uint cchText)
	{
		uint result = FnTable.GetKeyboardText(pchText,cchText);
		return result;
	}
	public void HideKeyboard()
	{
		FnTable.HideKeyboard();
	}
	public void SetKeyboardTransformAbsolute(ETrackingUniverseOrigin eTrackingOrigin,ref HmdMatrix34_t pmatTrackingOriginToKeyboardTransform)
	{
		FnTable.SetKeyboardTransformAbsolute(eTrackingOrigin,ref pmatTrackingOriginToKeyboardTransform);
	}
	public void SetKeyboardPositionForOverlay(ulong ulOverlayHandle,HmdRect2_t avoidRect)
	{
		FnTable.SetKeyboardPositionForOverlay(ulOverlayHandle,avoidRect);
	}
}


public class CVRRenderModels
{
	IVRRenderModels FnTable;
	internal CVRRenderModels(IntPtr pInterface)
	{
		FnTable = (IVRRenderModels)Marshal.PtrToStructure(pInterface, typeof(IVRRenderModels));
	}
	public EVRRenderModelError LoadRenderModel_Async(string pchRenderModelName,ref IntPtr ppRenderModel)
	{
		EVRRenderModelError result = FnTable.LoadRenderModel_Async(pchRenderModelName,ref ppRenderModel);
		return result;
	}
	public void FreeRenderModel(IntPtr pRenderModel)
	{
		FnTable.FreeRenderModel(pRenderModel);
	}
	public EVRRenderModelError LoadTexture_Async(int textureId,ref IntPtr ppTexture)
	{
		EVRRenderModelError result = FnTable.LoadTexture_Async(textureId,ref ppTexture);
		return result;
	}
	public void FreeTexture(IntPtr pTexture)
	{
		FnTable.FreeTexture(pTexture);
	}
	public EVRRenderModelError LoadTextureD3D11_Async(int textureId,IntPtr pD3D11Device,ref IntPtr ppD3D11Texture2D)
	{
		EVRRenderModelError result = FnTable.LoadTextureD3D11_Async(textureId,pD3D11Device,ref ppD3D11Texture2D);
		return result;
	}
	public EVRRenderModelError LoadIntoTextureD3D11_Async(int textureId,IntPtr pDstTexture)
	{
		EVRRenderModelError result = FnTable.LoadIntoTextureD3D11_Async(textureId,pDstTexture);
		return result;
	}
	public void FreeTextureD3D11(IntPtr pD3D11Texture2D)
	{
		FnTable.FreeTextureD3D11(pD3D11Texture2D);
	}
	public uint GetRenderModelName(uint unRenderModelIndex,System.Text.StringBuilder pchRenderModelName,uint unRenderModelNameLen)
	{
		uint result = FnTable.GetRenderModelName(unRenderModelIndex,pchRenderModelName,unRenderModelNameLen);
		return result;
	}
	public uint GetRenderModelCount()
	{
		uint result = FnTable.GetRenderModelCount();
		return result;
	}
	public uint GetComponentCount(string pchRenderModelName)
	{
		uint result = FnTable.GetComponentCount(pchRenderModelName);
		return result;
	}
	public uint GetComponentName(string pchRenderModelName,uint unComponentIndex,System.Text.StringBuilder pchComponentName,uint unComponentNameLen)
	{
		uint result = FnTable.GetComponentName(pchRenderModelName,unComponentIndex,pchComponentName,unComponentNameLen);
		return result;
	}
	public ulong GetComponentButtonMask(string pchRenderModelName,string pchComponentName)
	{
		ulong result = FnTable.GetComponentButtonMask(pchRenderModelName,pchComponentName);
		return result;
	}
	public uint GetComponentRenderModelName(string pchRenderModelName,string pchComponentName,System.Text.StringBuilder pchComponentRenderModelName,uint unComponentRenderModelNameLen)
	{
		uint result = FnTable.GetComponentRenderModelName(pchRenderModelName,pchComponentName,pchComponentRenderModelName,unComponentRenderModelNameLen);
		return result;
	}
	public bool GetComponentState(string pchRenderModelName,string pchComponentName,ref VRControllerState_t pControllerState,ref RenderModel_ControllerMode_State_t pState,ref RenderModel_ComponentState_t pComponentState)
	{
		bool result = FnTable.GetComponentState(pchRenderModelName,pchComponentName,ref pControllerState,ref pState,ref pComponentState);
		return result;
	}
	public bool RenderModelHasComponent(string pchRenderModelName,string pchComponentName)
	{
		bool result = FnTable.RenderModelHasComponent(pchRenderModelName,pchComponentName);
		return result;
	}
}


public class CVRNotifications
{
	IVRNotifications FnTable;
	internal CVRNotifications(IntPtr pInterface)
	{
		FnTable = (IVRNotifications)Marshal.PtrToStructure(pInterface, typeof(IVRNotifications));
	}
	public EVRNotificationError CreateNotification(ulong ulOverlayHandle,ulong ulUserValue,EVRNotificationType type,string pchText,EVRNotificationStyle style,ref NotificationBitmap_t pImage,ref uint pNotificationId)
	{
		pNotificationId = 0;
		EVRNotificationError result = FnTable.CreateNotification(ulOverlayHandle,ulUserValue,type,pchText,style,ref pImage,ref pNotificationId);
		return result;
	}
	public EVRNotificationError RemoveNotification(uint notificationId)
	{
		EVRNotificationError result = FnTable.RemoveNotification(notificationId);
		return result;
	}
}


public class CVRSettings
{
	IVRSettings FnTable;
	internal CVRSettings(IntPtr pInterface)
	{
		FnTable = (IVRSettings)Marshal.PtrToStructure(pInterface, typeof(IVRSettings));
	}
	public string GetSettingsErrorNameFromEnum(EVRSettingsError eError)
	{
		IntPtr result = FnTable.GetSettingsErrorNameFromEnum(eError);
		return (string) Marshal.PtrToStructure(result, typeof(string));
	}
	public bool Sync(bool bForce,ref EVRSettingsError peError)
	{
		bool result = FnTable.Sync(bForce,ref peError);
		return result;
	}
	public bool GetBool(string pchSection,string pchSettingsKey,bool bDefaultValue,ref EVRSettingsError peError)
	{
		bool result = FnTable.GetBool(pchSection,pchSettingsKey,bDefaultValue,ref peError);
		return result;
	}
	public void SetBool(string pchSection,string pchSettingsKey,bool bValue,ref EVRSettingsError peError)
	{
		FnTable.SetBool(pchSection,pchSettingsKey,bValue,ref peError);
	}
	public int GetInt32(string pchSection,string pchSettingsKey,int nDefaultValue,ref EVRSettingsError peError)
	{
		int result = FnTable.GetInt32(pchSection,pchSettingsKey,nDefaultValue,ref peError);
		return result;
	}
	public void SetInt32(string pchSection,string pchSettingsKey,int nValue,ref EVRSettingsError peError)
	{
		FnTable.SetInt32(pchSection,pchSettingsKey,nValue,ref peError);
	}
	public float GetFloat(string pchSection,string pchSettingsKey,float flDefaultValue,ref EVRSettingsError peError)
	{
		float result = FnTable.GetFloat(pchSection,pchSettingsKey,flDefaultValue,ref peError);
		return result;
	}
	public void SetFloat(string pchSection,string pchSettingsKey,float flValue,ref EVRSettingsError peError)
	{
		FnTable.SetFloat(pchSection,pchSettingsKey,flValue,ref peError);
	}
	public void GetString(string pchSection,string pchSettingsKey,string pchValue,uint unValueLen,string pchDefaultValue,ref EVRSettingsError peError)
	{
		FnTable.GetString(pchSection,pchSettingsKey,pchValue,unValueLen,pchDefaultValue,ref peError);
	}
	public void SetString(string pchSection,string pchSettingsKey,string pchValue,ref EVRSettingsError peError)
	{
		FnTable.SetString(pchSection,pchSettingsKey,pchValue,ref peError);
	}
	public void RemoveSection(string pchSection,ref EVRSettingsError peError)
	{
		FnTable.RemoveSection(pchSection,ref peError);
	}
	public void RemoveKeyInSection(string pchSection,string pchSettingsKey,ref EVRSettingsError peError)
	{
		FnTable.RemoveKeyInSection(pchSection,pchSettingsKey,ref peError);
	}
}


public class CVRTrackedCamera
{
	IVRTrackedCamera FnTable;
	internal CVRTrackedCamera(IntPtr pInterface)
	{
		FnTable = (IVRTrackedCamera)Marshal.PtrToStructure(pInterface, typeof(IVRTrackedCamera));
	}
	public bool HasCamera(uint nDeviceIndex)
	{
		bool result = FnTable.HasCamera(nDeviceIndex);
		return result;
	}
	public bool GetCameraFirmwareDescription(uint nDeviceIndex,string pBuffer,uint nBufferLen)
	{
		bool result = FnTable.GetCameraFirmwareDescription(nDeviceIndex,pBuffer,nBufferLen);
		return result;
	}
	public bool GetCameraFrameDimensions(uint nDeviceIndex,ECameraVideoStreamFormat nVideoStreamFormat,ref uint pWidth,ref uint pHeight)
	{
		pWidth = 0;
		pHeight = 0;
		bool result = FnTable.GetCameraFrameDimensions(nDeviceIndex,nVideoStreamFormat,ref pWidth,ref pHeight);
		return result;
	}
	public bool SetCameraVideoStreamFormat(uint nDeviceIndex,ECameraVideoStreamFormat nVideoStreamFormat)
	{
		bool result = FnTable.SetCameraVideoStreamFormat(nDeviceIndex,nVideoStreamFormat);
		return result;
	}
	public ECameraVideoStreamFormat GetCameraVideoStreamFormat(uint nDeviceIndex)
	{
		ECameraVideoStreamFormat result = FnTable.GetCameraVideoStreamFormat(nDeviceIndex);
		return result;
	}
	public bool EnableCameraForStreaming(uint nDeviceIndex,bool bEnable)
	{
		bool result = FnTable.EnableCameraForStreaming(nDeviceIndex,bEnable);
		return result;
	}
	public bool StartVideoStream(uint nDeviceIndex)
	{
		bool result = FnTable.StartVideoStream(nDeviceIndex);
		return result;
	}
	public bool StopVideoStream(uint nDeviceIndex)
	{
		bool result = FnTable.StopVideoStream(nDeviceIndex);
		return result;
	}
	public bool IsVideoStreamActive(uint nDeviceIndex,ref bool pbPaused,ref float pflElapsedTime)
	{
		pbPaused = false;
		pflElapsedTime = 0;
		bool result = FnTable.IsVideoStreamActive(nDeviceIndex,ref pbPaused,ref pflElapsedTime);
		return result;
	}
	public CameraVideoStreamFrame_t GetVideoStreamFrame(uint nDeviceIndex)
	{
		IntPtr result = FnTable.GetVideoStreamFrame(nDeviceIndex);
		return (CameraVideoStreamFrame_t) Marshal.PtrToStructure(result, typeof(CameraVideoStreamFrame_t));
	}
	public bool ReleaseVideoStreamFrame(uint nDeviceIndex,ref CameraVideoStreamFrame_t pFrameImage)
	{
		bool result = FnTable.ReleaseVideoStreamFrame(nDeviceIndex,ref pFrameImage);
		return result;
	}
	public bool SetAutoExposure(uint nDeviceIndex,bool bEnable)
	{
		bool result = FnTable.SetAutoExposure(nDeviceIndex,bEnable);
		return result;
	}
	public bool PauseVideoStream(uint nDeviceIndex)
	{
		bool result = FnTable.PauseVideoStream(nDeviceIndex);
		return result;
	}
	public bool ResumeVideoStream(uint nDeviceIndex)
	{
		bool result = FnTable.ResumeVideoStream(nDeviceIndex);
		return result;
	}
	public bool GetCameraDistortion(uint nDeviceIndex,float flInputU,float flInputV,ref float pflOutputU,ref float pflOutputV)
	{
		pflOutputU = 0;
		pflOutputV = 0;
		bool result = FnTable.GetCameraDistortion(nDeviceIndex,flInputU,flInputV,ref pflOutputU,ref pflOutputV);
		return result;
	}
	public bool GetCameraProjection(uint nDeviceIndex,float flWidthPixels,float flHeightPixels,float flZNear,float flZFar,ref HmdMatrix44_t pProjection)
	{
		bool result = FnTable.GetCameraProjection(nDeviceIndex,flWidthPixels,flHeightPixels,flZNear,flZFar,ref pProjection);
		return result;
	}
	public bool GetRecommendedCameraUndistortion(uint nDeviceIndex,ref uint pUndistortionWidthPixels,ref uint pUndistortionHeightPixels)
	{
		pUndistortionWidthPixels = 0;
		pUndistortionHeightPixels = 0;
		bool result = FnTable.GetRecommendedCameraUndistortion(nDeviceIndex,ref pUndistortionWidthPixels,ref pUndistortionHeightPixels);
		return result;
	}
	public bool SetCameraUndistortion(uint nDeviceIndex,uint nUndistortionWidthPixels,uint nUndistortionHeightPixels)
	{
		bool result = FnTable.SetCameraUndistortion(nDeviceIndex,nUndistortionWidthPixels,nUndistortionHeightPixels);
		return result;
	}
	public void RequestVideoServicesForTool()
	{
		FnTable.RequestVideoServicesForTool();
	}
	public void ReleaseVideoServicesForTool()
	{
		FnTable.ReleaseVideoServicesForTool();
	}
	public bool GetVideoStreamFrameSharedTextureGL(bool bUndistorted,ref uint pglTextureId,IntPtr pglSharedTextureHandle)
	{
		pglTextureId = 0;
		bool result = FnTable.GetVideoStreamFrameSharedTextureGL(bUndistorted,ref pglTextureId,pglSharedTextureHandle);
		return result;
	}
	public bool ReleaseVideoStreamFrameSharedTextureGL(uint glTextureId,IntPtr glSharedTextureHandle)
	{
		bool result = FnTable.ReleaseVideoStreamFrameSharedTextureGL(glTextureId,glSharedTextureHandle);
		return result;
	}
	public void LockSharedTextureGL(IntPtr glSharedTextureHandle,ref CameraVideoStreamFrame_t pFrameImage)
	{
		FnTable.LockSharedTextureGL(glSharedTextureHandle,ref pFrameImage);
	}
	public void UnlockSharedTextureGL(IntPtr glSharedTextureHandle)
	{
		FnTable.UnlockSharedTextureGL(glSharedTextureHandle);
	}
}


public class OpenVRInterop
{
	[DllImportAttribute("openvr_api", EntryPoint = "VR_InitInternal")]
	internal static extern uint InitInternal(ref EVRInitError peError, EVRApplicationType eApplicationType);
	[DllImportAttribute("openvr_api", EntryPoint = "VR_ShutdownInternal")]
	internal static extern void ShutdownInternal();
	[DllImportAttribute("openvr_api", EntryPoint = "VR_IsHmdPresent")]
	internal static extern bool IsHmdPresent();
	[DllImportAttribute("openvr_api", EntryPoint = "VR_IsRuntimeInstalled")]
	internal static extern bool IsRuntimeInstalled();
	[DllImportAttribute("openvr_api", EntryPoint = "VR_GetStringForHmdError")]
	internal static extern IntPtr GetStringForHmdError(EVRInitError error);
	[DllImportAttribute("openvr_api", EntryPoint = "VR_GetGenericInterface")]
	internal static extern IntPtr GetGenericInterface([In, MarshalAs(UnmanagedType.LPStr)] string pchInterfaceVersion, ref EVRInitError peError);
	[DllImportAttribute("openvr_api", EntryPoint = "VR_IsInterfaceVersionValid")]
	internal static extern bool IsInterfaceVersionValid([In, MarshalAs(UnmanagedType.LPStr)] string pchInterfaceVersion);
	[DllImportAttribute("openvr_api", EntryPoint = "VR_GetInitToken")]
	internal static extern uint GetInitToken();
}


public enum EVREye
{
	Eye_Left = 0,
	Eye_Right = 1,
}
public enum EGraphicsAPIConvention
{
	API_DirectX = 0,
	API_OpenGL = 1,
}
public enum EColorSpace
{
	Auto = 0,
	Gamma = 1,
	Linear = 2,
}
public enum ETrackingResult
{
	Uninitialized = 1,
	Calibrating_InProgress = 100,
	Calibrating_OutOfRange = 101,
	Running_OK = 200,
	Running_OutOfRange = 201,
}
public enum ETrackedDeviceClass
{
	Invalid = 0,
	HMD = 1,
	Controller = 2,
	TrackingReference = 4,
	Other = 1000,
}
public enum ETrackedControllerRole
{
	Invalid = 0,
	LeftHand = 1,
	RightHand = 2,
}
public enum ETrackingUniverseOrigin
{
	TrackingUniverseSeated = 0,
	TrackingUniverseStanding = 1,
	TrackingUniverseRawAndUncalibrated = 2,
}
public enum ETrackedDeviceProperty
{
	Prop_TrackingSystemName_String = 1000,
	Prop_ModelNumber_String = 1001,
	Prop_SerialNumber_String = 1002,
	Prop_RenderModelName_String = 1003,
	Prop_WillDriftInYaw_Bool = 1004,
	Prop_ManufacturerName_String = 1005,
	Prop_TrackingFirmwareVersion_String = 1006,
	Prop_HardwareRevision_String = 1007,
	Prop_AllWirelessDongleDescriptions_String = 1008,
	Prop_ConnectedWirelessDongle_String = 1009,
	Prop_DeviceIsWireless_Bool = 1010,
	Prop_DeviceIsCharging_Bool = 1011,
	Prop_DeviceBatteryPercentage_Float = 1012,
	Prop_StatusDisplayTransform_Matrix34 = 1013,
	Prop_Firmware_UpdateAvailable_Bool = 1014,
	Prop_Firmware_ManualUpdate_Bool = 1015,
	Prop_Firmware_ManualUpdateURL_String = 1016,
	Prop_HardwareRevision_Uint64 = 1017,
	Prop_FirmwareVersion_Uint64 = 1018,
	Prop_FPGAVersion_Uint64 = 1019,
	Prop_VRCVersion_Uint64 = 1020,
	Prop_RadioVersion_Uint64 = 1021,
	Prop_DongleVersion_Uint64 = 1022,
	Prop_BlockServerShutdown_Bool = 1023,
	Prop_CanUnifyCoordinateSystemWithHmd_Bool = 1024,
	Prop_ContainsProximitySensor_Bool = 1025,
	Prop_DeviceProvidesBatteryStatus_Bool = 1026,
	Prop_DeviceCanPowerOff_Bool = 1027,
	Prop_Firmware_ProgrammingTarget_String = 1028,
	Prop_DeviceClass_Int32 = 1029,
	Prop_HasCamera_Bool = 1030,
	Prop_ReportsTimeSinceVSync_Bool = 2000,
	Prop_SecondsFromVsyncToPhotons_Float = 2001,
	Prop_DisplayFrequency_Float = 2002,
	Prop_UserIpdMeters_Float = 2003,
	Prop_CurrentUniverseId_Uint64 = 2004,
	Prop_PreviousUniverseId_Uint64 = 2005,
	Prop_DisplayFirmwareVersion_Uint64 = 2006,
	Prop_IsOnDesktop_Bool = 2007,
	Prop_DisplayMCType_Int32 = 2008,
	Prop_DisplayMCOffset_Float = 2009,
	Prop_DisplayMCScale_Float = 2010,
	Prop_EdidVendorID_Int32 = 2011,
	Prop_DisplayMCImageLeft_String = 2012,
	Prop_DisplayMCImageRight_String = 2013,
	Prop_DisplayGCBlackClamp_Float = 2014,
	Prop_EdidProductID_Int32 = 2015,
	Prop_CameraToHeadTransform_Matrix34 = 2016,
	Prop_DisplayGCType_Int32 = 2017,
	Prop_DisplayGCOffset_Float = 2018,
	Prop_DisplayGCScale_Float = 2019,
	Prop_DisplayGCPrescale_Float = 2020,
	Prop_DisplayGCImage_String = 2021,
	Prop_LensCenterLeftU_Float = 2022,
	Prop_LensCenterLeftV_Float = 2023,
	Prop_LensCenterRightU_Float = 2024,
	Prop_LensCenterRightV_Float = 2025,
	Prop_UserHeadToEyeDepthMeters_Float = 2026,
	Prop_CameraFirmwareVersion_Uint64 = 2027,
	Prop_CameraFirmwareDescription_String = 2028,
	Prop_DisplayFPGAVersion_Uint64 = 2029,
	Prop_DisplayBootloaderVersion_Uint64 = 2030,
	Prop_DisplayHardwareVersion_Uint64 = 2031,
	Prop_AudioFirmwareVersion_Uint64 = 2032,
	Prop_AttachedDeviceId_String = 3000,
	Prop_SupportedButtons_Uint64 = 3001,
	Prop_Axis0Type_Int32 = 3002,
	Prop_Axis1Type_Int32 = 3003,
	Prop_Axis2Type_Int32 = 3004,
	Prop_Axis3Type_Int32 = 3005,
	Prop_Axis4Type_Int32 = 3006,
	Prop_FieldOfViewLeftDegrees_Float = 4000,
	Prop_FieldOfViewRightDegrees_Float = 4001,
	Prop_FieldOfViewTopDegrees_Float = 4002,
	Prop_FieldOfViewBottomDegrees_Float = 4003,
	Prop_TrackingRangeMinimumMeters_Float = 4004,
	Prop_TrackingRangeMaximumMeters_Float = 4005,
	Prop_ModeLabel_String = 4006,
	Prop_VendorSpecific_Reserved_Start = 10000,
	Prop_VendorSpecific_Reserved_End = 10999,
}
public enum ETrackedPropertyError
{
	TrackedProp_Success = 0,
	TrackedProp_WrongDataType = 1,
	TrackedProp_WrongDeviceClass = 2,
	TrackedProp_BufferTooSmall = 3,
	TrackedProp_UnknownProperty = 4,
	TrackedProp_InvalidDevice = 5,
	TrackedProp_CouldNotContactServer = 6,
	TrackedProp_ValueNotProvidedByDevice = 7,
	TrackedProp_StringExceedsMaximumLength = 8,
	TrackedProp_NotYetAvailable = 9,
}
public enum EVRSubmitFlags
{
	Submit_Default = 0,
	Submit_LensDistortionAlreadyApplied = 1,
	Submit_GlRenderBuffer = 2,
}
public enum EVRState
{
	Undefined = -1,
	Off = 0,
	Searching = 1,
	Searching_Alert = 2,
	Ready = 3,
	Ready_Alert = 4,
	NotReady = 5,
}
public enum EVREventType
{
	VREvent_None = 0,
	VREvent_TrackedDeviceActivated = 100,
	VREvent_TrackedDeviceDeactivated = 101,
	VREvent_TrackedDeviceUpdated = 102,
	VREvent_TrackedDeviceUserInteractionStarted = 103,
	VREvent_TrackedDeviceUserInteractionEnded = 104,
	VREvent_IpdChanged = 105,
	VREvent_EnterStandbyMode = 106,
	VREvent_LeaveStandbyMode = 107,
	VREvent_TrackedDeviceRoleChanged = 108,
	VREvent_ButtonPress = 200,
	VREvent_ButtonUnpress = 201,
	VREvent_ButtonTouch = 202,
	VREvent_ButtonUntouch = 203,
	VREvent_MouseMove = 300,
	VREvent_MouseButtonDown = 301,
	VREvent_MouseButtonUp = 302,
	VREvent_FocusEnter = 303,
	VREvent_FocusLeave = 304,
	VREvent_Scroll = 305,
	VREvent_TouchPadMove = 306,
	VREvent_InputFocusCaptured = 400,
	VREvent_InputFocusReleased = 401,
	VREvent_SceneFocusLost = 402,
	VREvent_SceneFocusGained = 403,
	VREvent_SceneApplicationChanged = 404,
	VREvent_SceneFocusChanged = 405,
	VREvent_HideRenderModels = 410,
	VREvent_ShowRenderModels = 411,
	VREvent_OverlayShown = 500,
	VREvent_OverlayHidden = 501,
	VREvent_DashboardActivated = 502,
	VREvent_DashboardDeactivated = 503,
	VREvent_DashboardThumbSelected = 504,
	VREvent_DashboardRequested = 505,
	VREvent_ResetDashboard = 506,
	VREvent_RenderToast = 507,
	VREvent_ImageLoaded = 508,
	VREvent_ShowKeyboard = 509,
	VREvent_HideKeyboard = 510,
	VREvent_OverlayGamepadFocusGained = 511,
	VREvent_OverlayGamepadFocusLost = 512,
	VREvent_Notification_Shown = 600,
	VREvent_Notification_Hidden = 601,
	VREvent_Notification_BeginInteraction = 602,
	VREvent_Notification_Destroyed = 603,
	VREvent_Quit = 700,
	VREvent_ProcessQuit = 701,
	VREvent_QuitAborted_UserPrompt = 702,
	VREvent_QuitAcknowledged = 703,
	VREvent_ChaperoneDataHasChanged = 800,
	VREvent_ChaperoneUniverseHasChanged = 801,
	VREvent_ChaperoneTempDataHasChanged = 802,
	VREvent_ChaperoneSettingsHaveChanged = 803,
	VREvent_SeatedZeroPoseReset = 804,
	VREvent_BackgroundSettingHasChanged = 850,
	VREvent_CameraSettingsHaveChanged = 851,
	VREvent_StatusUpdate = 900,
	VREvent_MCImageUpdated = 1000,
	VREvent_FirmwareUpdateStarted = 1100,
	VREvent_FirmwareUpdateFinished = 1101,
	VREvent_KeyboardClosed = 1200,
	VREvent_KeyboardCharInput = 1201,
	VREvent_KeyboardDone = 1202,
	VREvent_ApplicationTransitionStarted = 1300,
	VREvent_ApplicationTransitionAborted = 1301,
	VREvent_ApplicationTransitionNewAppStarted = 1302,
	VREvent_Compositor_MirrorWindowShown = 1400,
	VREvent_Compositor_MirrorWindowHidden = 1401,
	VREvent_Compositor_ChaperoneBoundsShown = 1410,
	VREvent_Compositor_ChaperoneBoundsHidden = 1411,
	VREvent_TrackedCamera_StartVideoStream = 1500,
	VREvent_TrackedCamera_StopVideoStream = 1501,
	VREvent_TrackedCamera_PauseVideoStream = 1502,
	VREvent_TrackedCamera_ResumeVideoStream = 1503,
	VREvent_PerformanceTest_EnableCapture = 1600,
	VREvent_PerformanceTest_DisableCapture = 1601,
	VREvent_PerformanceTest_FidelityLevel = 1602,
	VREvent_VendorSpecific_Reserved_Start = 10000,
	VREvent_VendorSpecific_Reserved_End = 19999,
}
public enum EDeviceActivityLevel
{
	k_EDeviceActivityLevel_Unknown = -1,
	k_EDeviceActivityLevel_Idle = 0,
	k_EDeviceActivityLevel_UserInteraction = 1,
	k_EDeviceActivityLevel_UserInteraction_Timeout = 2,
	k_EDeviceActivityLevel_Standby = 3,
}
public enum EVRButtonId
{
	k_EButton_System = 0,
	k_EButton_ApplicationMenu = 1,
	k_EButton_Grip = 2,
	k_EButton_DPad_Left = 3,
	k_EButton_DPad_Up = 4,
	k_EButton_DPad_Right = 5,
	k_EButton_DPad_Down = 6,
	k_EButton_A = 7,
	k_EButton_Axis0 = 32,
	k_EButton_Axis1 = 33,
	k_EButton_Axis2 = 34,
	k_EButton_Axis3 = 35,
	k_EButton_Axis4 = 36,
	k_EButton_SteamVR_Touchpad = 32,
	k_EButton_SteamVR_Trigger = 33,
	k_EButton_Dashboard_Back = 2,
	k_EButton_Max = 64,
}
public enum EVRMouseButton
{
	Left = 1,
	Right = 2,
	Middle = 4,
}
public enum EVRControllerAxisType
{
	k_eControllerAxis_None = 0,
	k_eControllerAxis_TrackPad = 1,
	k_eControllerAxis_Joystick = 2,
	k_eControllerAxis_Trigger = 3,
}
public enum EVRControllerEventOutputType
{
	ControllerEventOutput_OSEvents = 0,
	ControllerEventOutput_VREvents = 1,
}
public enum ECollisionBoundsStyle
{
	COLLISION_BOUNDS_STYLE_BEGINNER = 0,
	COLLISION_BOUNDS_STYLE_INTERMEDIATE = 1,
	COLLISION_BOUNDS_STYLE_SQUARES = 2,
	COLLISION_BOUNDS_STYLE_ADVANCED = 3,
	COLLISION_BOUNDS_STYLE_NONE = 4,
	COLLISION_BOUNDS_STYLE_COUNT = 5,
}
public enum EVROverlayError
{
	None = 0,
	UnknownOverlay = 10,
	InvalidHandle = 11,
	PermissionDenied = 12,
	OverlayLimitExceeded = 13,
	WrongVisibilityType = 14,
	KeyTooLong = 15,
	NameTooLong = 16,
	KeyInUse = 17,
	WrongTransformType = 18,
	InvalidTrackedDevice = 19,
	InvalidParameter = 20,
	ThumbnailCantBeDestroyed = 21,
	ArrayTooSmall = 22,
	RequestFailed = 23,
	InvalidTexture = 24,
	UnableToLoadFile = 25,
	VROVerlayError_KeyboardAlreadyInUse = 26,
	NoNeighbor = 27,
}
public enum EVRApplicationType
{
	VRApplication_Other = 0,
	VRApplication_Scene = 1,
	VRApplication_Overlay = 2,
	VRApplication_Background = 3,
	VRApplication_Utility = 4,
}
public enum EVRFirmwareError
{
	None = 0,
	Success = 1,
	Fail = 2,
}
public enum EVRNotificationError
{
	OK = 0,
	InvalidNotificationId = 100,
	NotificationQueueFull = 101,
	InvalidOverlayHandle = 102,
}
public enum EVRInitError
{
	None = 0,
	Unknown = 1,
	Init_InstallationNotFound = 100,
	Init_InstallationCorrupt = 101,
	Init_VRClientDLLNotFound = 102,
	Init_FileNotFound = 103,
	Init_FactoryNotFound = 104,
	Init_InterfaceNotFound = 105,
	Init_InvalidInterface = 106,
	Init_UserConfigDirectoryInvalid = 107,
	Init_HmdNotFound = 108,
	Init_NotInitialized = 109,
	Init_PathRegistryNotFound = 110,
	Init_NoConfigPath = 111,
	Init_NoLogPath = 112,
	Init_PathRegistryNotWritable = 113,
	Init_AppInfoInitFailed = 114,
	Init_Retry = 115,
	Init_InitCanceledByUser = 116,
	Init_AnotherAppLaunching = 117,
	Init_SettingsInitFailed = 118,
	Init_ShuttingDown = 119,
	Init_TooManyObjects = 120,
	Init_NoServerForBackgroundApp = 121,
	Init_NotSupportedWithCompositor = 122,
	Init_NotAvailableToUtilityApps = 123,
	Driver_Failed = 200,
	Driver_Unknown = 201,
	Driver_HmdUnknown = 202,
	Driver_NotLoaded = 203,
	Driver_RuntimeOutOfDate = 204,
	Driver_HmdInUse = 205,
	Driver_NotCalibrated = 206,
	Driver_CalibrationInvalid = 207,
	Driver_HmdDisplayNotFound = 208,
	IPC_ServerInitFailed = 300,
	IPC_ConnectFailed = 301,
	IPC_SharedStateInitFailed = 302,
	IPC_CompositorInitFailed = 303,
	IPC_MutexInitFailed = 304,
	IPC_Failed = 305,
	Compositor_Failed = 400,
	Compositor_D3D11HardwareRequired = 401,
	VendorSpecific_UnableToConnectToOculusRuntime = 1000,
	VendorSpecific_HmdFound_CantOpenDevice = 1101,
	VendorSpecific_HmdFound_UnableToRequestConfigStart = 1102,
	VendorSpecific_HmdFound_NoStoredConfig = 1103,
	VendorSpecific_HmdFound_ConfigTooBig = 1104,
	VendorSpecific_HmdFound_ConfigTooSmall = 1105,
	VendorSpecific_HmdFound_UnableToInitZLib = 1106,
	VendorSpecific_HmdFound_CantReadFirmwareVersion = 1107,
	VendorSpecific_HmdFound_UnableToSendUserDataStart = 1108,
	VendorSpecific_HmdFound_UnableToGetUserDataStart = 1109,
	VendorSpecific_HmdFound_UnableToGetUserDataNext = 1110,
	VendorSpecific_HmdFound_UserDataAddressRange = 1111,
	VendorSpecific_HmdFound_UserDataError = 1112,
	VendorSpecific_HmdFound_ConfigFailedSanityCheck = 1113,
	Steam_SteamInstallationNotFound = 2000,
}
public enum EVRApplicationError
{
	None = 0,
	AppKeyAlreadyExists = 100,
	NoManifest = 101,
	NoApplication = 102,
	InvalidIndex = 103,
	UnknownApplication = 104,
	IPCFailed = 105,
	ApplicationAlreadyRunning = 106,
	InvalidManifest = 107,
	InvalidApplication = 108,
	LaunchFailed = 109,
	ApplicationAlreadyStarting = 110,
	LaunchInProgress = 111,
	OldApplicationQuitting = 112,
	TransitionAborted = 113,
	BufferTooSmall = 200,
	PropertyNotSet = 201,
	UnknownProperty = 202,
}
public enum EVRApplicationProperty
{
	Name_String = 0,
	LaunchType_String = 11,
	WorkingDirectory_String = 12,
	BinaryPath_String = 13,
	Arguments_String = 14,
	URL_String = 15,
	Description_String = 50,
	NewsURL_String = 51,
	ImagePath_String = 52,
	Source_String = 53,
	IsDashboardOverlay_Bool = 60,
	LastLaunchTime_Uint64 = 70,
}
public enum EVRApplicationTransitionState
{
	VRApplicationTransition_None = 0,
	VRApplicationTransition_OldAppQuitSent = 10,
	VRApplicationTransition_WaitingForExternalLaunch = 11,
	VRApplicationTransition_NewAppLaunched = 20,
}
public enum ChaperoneCalibrationState
{
	OK = 1,
	Warning = 100,
	Warning_BaseStationMayHaveMoved = 101,
	Warning_BaseStationRemoved = 102,
	Warning_SeatedBoundsInvalid = 103,
	Error = 200,
	Error_BaseStationUninitalized = 201,
	Error_BaseStationConflict = 202,
	Error_PlayAreaInvalid = 203,
	Error_CollisionBoundsInvalid = 204,
}
public enum EChaperoneConfigFile
{
	Live = 1,
	Temp = 2,
}
public enum EChaperoneImportFlags
{
	EChaperoneImport_BoundsOnly = 1,
}
public enum EVRCompositorError
{
	None = 0,
	IncompatibleVersion = 100,
	DoNotHaveFocus = 101,
	InvalidTexture = 102,
	IsNotSceneApplication = 103,
	TextureIsOnWrongDevice = 104,
	TextureUsesUnsupportedFormat = 105,
	SharedTexturesNotSupported = 106,
	IndexOutOfRange = 107,
}
public enum VROverlayInputMethod
{
	None = 0,
	Mouse = 1,
}
public enum VROverlayTransformType
{
	VROverlayTransform_Absolute = 0,
	VROverlayTransform_TrackedDeviceRelative = 1,
	VROverlayTransform_SystemOverlay = 2,
	VROverlayTransform_TrackedComponent = 3,
}
public enum VROverlayFlags
{
	None = 0,
	Curved = 1,
	RGSS4X = 2,
	NoDashboardTab = 3,
	AcceptsGamepadEvents = 4,
	ShowGamepadFocus = 5,
	SendVRScrollEvents = 6,
	SendVRTouchpadEvents = 7,
	ShowTouchPadScrollWheel = 8,
}
public enum EGamepadTextInputMode
{
	k_EGamepadTextInputModeNormal = 0,
	k_EGamepadTextInputModePassword = 1,
	k_EGamepadTextInputModeSubmit = 2,
}
public enum EGamepadTextInputLineMode
{
	k_EGamepadTextInputLineModeSingleLine = 0,
	k_EGamepadTextInputLineModeMultipleLines = 1,
}
public enum EOverlayDirection
{
	Up = 0,
	Down = 1,
	Left = 2,
	Right = 3,
	Count = 4,
}
public enum EVRRenderModelError
{
	None = 0,
	Loading = 100,
	NotSupported = 200,
	InvalidArg = 300,
	InvalidModel = 301,
	NoShapes = 302,
	MultipleShapes = 303,
	TooManyIndices = 304,
	MultipleTextures = 305,
	InvalidTexture = 400,
}
public enum EVRComponentProperty
{
	IsStatic = 1,
	IsVisible = 2,
	IsTouched = 4,
	IsPressed = 8,
	IsScrolled = 16,
}
public enum EVRNotificationType
{
	Transient = 0,
	Persistent = 1,
}
public enum EVRNotificationStyle
{
	None = 0,
	Application = 100,
	Contact_Disabled = 200,
	Contact_Enabled = 201,
	Contact_Active = 202,
}
public enum EVRSettingsError
{
	None = 0,
	IPCFailed = 1,
	WriteFailed = 2,
	ReadFailed = 3,
}
public enum ECameraVideoStreamFormat
{
	CVS_FORMAT_UNKNOWN = 0,
	CVS_FORMAT_RAW10 = 1,
	CVS_FORMAT_NV12 = 2,
	CVS_FORMAT_RGB24 = 3,
	CVS_MAX_FORMATS = 4,
}

[StructLayout(LayoutKind.Explicit)] public struct VREvent_Data_t
{
	[FieldOffset(0)] public VREvent_Reserved_t reserved;
	[FieldOffset(0)] public VREvent_Controller_t controller;
	[FieldOffset(0)] public VREvent_Mouse_t mouse;
	[FieldOffset(0)] public VREvent_Scroll_t scroll;
	[FieldOffset(0)] public VREvent_Process_t process;
	[FieldOffset(0)] public VREvent_Notification_t notification;
	[FieldOffset(0)] public VREvent_Overlay_t overlay;
	[FieldOffset(0)] public VREvent_Status_t status;
	[FieldOffset(0)] public VREvent_Ipd_t ipd;
	[FieldOffset(0)] public VREvent_Chaperone_t chaperone;
	[FieldOffset(0)] public VREvent_PerformanceTest_t performanceTest;
	[FieldOffset(0)] public VREvent_TouchPadMove_t touchPadMove;
	[FieldOffset(0)] public VREvent_SeatedZeroPoseReset_t seatedZeroPoseReset;
	[FieldOffset(0)] public VREvent_Keyboard_t keyboard; // This has to be at the end due to a mono bug
}

[StructLayout(LayoutKind.Sequential)] public struct HmdMatrix34_t
{
	public float m0; //float[3][4]
	public float m1;
	public float m2;
	public float m3;
	public float m4;
	public float m5;
	public float m6;
	public float m7;
	public float m8;
	public float m9;
	public float m10;
	public float m11;
}
[StructLayout(LayoutKind.Sequential)] public struct HmdMatrix44_t
{
	public float m0; //float[4][4]
	public float m1;
	public float m2;
	public float m3;
	public float m4;
	public float m5;
	public float m6;
	public float m7;
	public float m8;
	public float m9;
	public float m10;
	public float m11;
	public float m12;
	public float m13;
	public float m14;
	public float m15;
}
[StructLayout(LayoutKind.Sequential)] public struct HmdVector3_t
{
	public float v0; //float[3]
	public float v1;
	public float v2;
}
[StructLayout(LayoutKind.Sequential)] public struct HmdVector4_t
{
	public float v0; //float[4]
	public float v1;
	public float v2;
	public float v3;
}
[StructLayout(LayoutKind.Sequential)] public struct HmdVector3d_t
{
	public double v0; //double[3]
	public double v1;
	public double v2;
}
[StructLayout(LayoutKind.Sequential)] public struct HmdVector2_t
{
	public float v0; //float[2]
	public float v1;
}
[StructLayout(LayoutKind.Sequential)] public struct HmdQuaternion_t
{
	public double w;
	public double x;
	public double y;
	public double z;
}
[StructLayout(LayoutKind.Sequential)] public struct HmdColor_t
{
	public float r;
	public float g;
	public float b;
	public float a;
}
[StructLayout(LayoutKind.Sequential)] public struct HmdQuad_t
{
	public HmdVector3_t vCorners0; //HmdVector3_t[4]
	public HmdVector3_t vCorners1;
	public HmdVector3_t vCorners2;
	public HmdVector3_t vCorners3;
}
[StructLayout(LayoutKind.Sequential)] public struct HmdRect2_t
{
	public HmdVector2_t vTopLeft;
	public HmdVector2_t vBottomRight;
}
[StructLayout(LayoutKind.Sequential)] public struct DistortionCoordinates_t
{
	public float rfRed0; //float[2]
	public float rfRed1;
	public float rfGreen0; //float[2]
	public float rfGreen1;
	public float rfBlue0; //float[2]
	public float rfBlue1;
}
[StructLayout(LayoutKind.Sequential)] public struct Texture_t
{
	public IntPtr handle; // void *
	public EGraphicsAPIConvention eType;
	public EColorSpace eColorSpace;
}
[StructLayout(LayoutKind.Sequential)] public struct TrackedDevicePose_t
{
	public HmdMatrix34_t mDeviceToAbsoluteTracking;
	public HmdVector3_t vVelocity;
	public HmdVector3_t vAngularVelocity;
	public ETrackingResult eTrackingResult;
	[MarshalAs(UnmanagedType.I1)]
	public bool bPoseIsValid;
	[MarshalAs(UnmanagedType.I1)]
	public bool bDeviceIsConnected;
}
[StructLayout(LayoutKind.Sequential)] public struct VRTextureBounds_t
{
	public float uMin;
	public float vMin;
	public float uMax;
	public float vMax;
}
[StructLayout(LayoutKind.Sequential)] public struct VREvent_Controller_t
{
	public uint button;
}
[StructLayout(LayoutKind.Sequential)] public struct VREvent_Mouse_t
{
	public float x;
	public float y;
	public uint button;
}
[StructLayout(LayoutKind.Sequential)] public struct VREvent_Scroll_t
{
	public float xdelta;
	public float ydelta;
	public uint repeatCount;
}
[StructLayout(LayoutKind.Sequential)] public struct VREvent_TouchPadMove_t
{
	[MarshalAs(UnmanagedType.I1)]
	public bool bFingerDown;
	public float flSecondsFingerDown;
	public float fValueXFirst;
	public float fValueYFirst;
	public float fValueXRaw;
	public float fValueYRaw;
}
[StructLayout(LayoutKind.Sequential)] public struct VREvent_Notification_t
{
	public ulong ulUserValue;
	public uint notificationId;
}
[StructLayout(LayoutKind.Sequential)] public struct VREvent_Process_t
{
	public uint pid;
	public uint oldPid;
	[MarshalAs(UnmanagedType.I1)]
	public bool bForced;
}
[StructLayout(LayoutKind.Sequential)] public struct VREvent_Overlay_t
{
	public ulong overlayHandle;
}
[StructLayout(LayoutKind.Sequential)] public struct VREvent_Status_t
{
	public uint statusState;
}
[StructLayout(LayoutKind.Sequential)] public struct VREvent_Keyboard_t
{
	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
	public string cNewInput; //char[8]
	public ulong uUserValue;
}
[StructLayout(LayoutKind.Sequential)] public struct VREvent_Ipd_t
{
	public float ipdMeters;
}
[StructLayout(LayoutKind.Sequential)] public struct VREvent_Chaperone_t
{
	public ulong m_nPreviousUniverse;
	public ulong m_nCurrentUniverse;
}
[StructLayout(LayoutKind.Sequential)] public struct VREvent_Reserved_t
{
	public ulong reserved0;
	public ulong reserved1;
}
[StructLayout(LayoutKind.Sequential)] public struct VREvent_PerformanceTest_t
{
	public uint m_nFidelityLevel;
}
[StructLayout(LayoutKind.Sequential)] public struct VREvent_SeatedZeroPoseReset_t
{
	[MarshalAs(UnmanagedType.I1)]
	public bool bResetBySystemMenu;
}
[StructLayout(LayoutKind.Sequential)] public struct VREvent_t
{
	public uint eventType;
	public uint trackedDeviceIndex;
	public float eventAgeSeconds;
	public VREvent_Data_t data;
}
[StructLayout(LayoutKind.Sequential)] public struct HiddenAreaMesh_t
{
	public IntPtr pVertexData; // const struct vr::HmdVector2_t *
	public uint unTriangleCount;
}
[StructLayout(LayoutKind.Sequential)] public struct VRControllerAxis_t
{
	public float x;
	public float y;
}
[StructLayout(LayoutKind.Sequential)] public struct VRControllerState_t
{
	public uint unPacketNum;
	public ulong ulButtonPressed;
	public ulong ulButtonTouched;
	public VRControllerAxis_t rAxis0; //VRControllerAxis_t[5]
	public VRControllerAxis_t rAxis1;
	public VRControllerAxis_t rAxis2;
	public VRControllerAxis_t rAxis3;
	public VRControllerAxis_t rAxis4;
}
[StructLayout(LayoutKind.Sequential)] public struct Compositor_OverlaySettings
{
	public uint size;
	[MarshalAs(UnmanagedType.I1)]
	public bool curved;
	[MarshalAs(UnmanagedType.I1)]
	public bool antialias;
	public float scale;
	public float distance;
	public float alpha;
	public float uOffset;
	public float vOffset;
	public float uScale;
	public float vScale;
	public float gridDivs;
	public float gridWidth;
	public float gridScale;
	public HmdMatrix44_t transform;
}
[StructLayout(LayoutKind.Sequential)] public struct Compositor_FrameTiming
{
	public uint m_nSize;
	public uint m_nFrameIndex;
	public uint m_nNumFramePresents;
	public uint m_nNumDroppedFrames;
	public double m_flSystemTimeInSeconds;
	public float m_flSceneRenderGpuMs;
	public float m_flTotalRenderGpuMs;
	public float m_flCompositorRenderGpuMs;
	public float m_flCompositorRenderCpuMs;
	public float m_flCompositorIdleCpuMs;
	public float m_flClientFrameIntervalMs;
	public float m_flPresentCallCpuMs;
	public float m_flWaitForPresentCpuMs;
	public float m_flSubmitFrameMs;
	public float m_flWaitGetPosesCalledMs;
	public float m_flNewPosesReadyMs;
	public float m_flNewFrameReadyMs;
	public float m_flCompositorUpdateStartMs;
	public float m_flCompositorUpdateEndMs;
	public float m_flCompositorRenderStartMs;
	public TrackedDevicePose_t m_HmdPose;
	public int m_nFidelityLevel;
}
[StructLayout(LayoutKind.Sequential)] public struct VROverlayIntersectionParams_t
{
	public HmdVector3_t vSource;
	public HmdVector3_t vDirection;
	public ETrackingUniverseOrigin eOrigin;
}
[StructLayout(LayoutKind.Sequential)] public struct VROverlayIntersectionResults_t
{
	public HmdVector3_t vPoint;
	public HmdVector3_t vNormal;
	public HmdVector2_t vUVs;
	public float fDistance;
}
[StructLayout(LayoutKind.Sequential)] public struct RenderModel_ComponentState_t
{
	public HmdMatrix34_t mTrackingToComponentRenderModel;
	public HmdMatrix34_t mTrackingToComponentLocal;
	public uint uProperties;
}
[StructLayout(LayoutKind.Sequential)] public struct RenderModel_Vertex_t
{
	public HmdVector3_t vPosition;
	public HmdVector3_t vNormal;
	public float rfTextureCoord0; //float[2]
	public float rfTextureCoord1;
}
[StructLayout(LayoutKind.Sequential)] public struct RenderModel_TextureMap_t
{
	public char unWidth;
	public char unHeight;
	public IntPtr rubTextureMapData; // const uint8_t *
}
[StructLayout(LayoutKind.Sequential)] public struct RenderModel_t
{
	public IntPtr rVertexData; // const struct vr::RenderModel_Vertex_t *
	public uint unVertexCount;
	public IntPtr rIndexData; // const uint16_t *
	public uint unTriangleCount;
	public int diffuseTextureId;
}
[StructLayout(LayoutKind.Sequential)] public struct RenderModel_ControllerMode_State_t
{
	[MarshalAs(UnmanagedType.I1)]
	public bool bScrollWheelVisible;
}
[StructLayout(LayoutKind.Sequential)] public struct NotificationBitmap_t
{
	public IntPtr bytes; // void *
	public int width;
	public int height;
	public int depth;
}
[StructLayout(LayoutKind.Sequential)] public struct CameraVideoStreamFrame_t
{
	public ECameraVideoStreamFormat m_nStreamFormat;
	public uint m_nWidth;
	public uint m_nHeight;
	public uint m_nImageDataSize;
	public uint m_nFrameSequence;
	public uint m_nBufferIndex;
	public uint m_nBufferCount;
	public uint m_nExposureTime;
	public uint m_nISPFrameTimeStamp;
	public uint m_nISPReferenceTimeStamp;
	public uint m_nSyncCounter;
	public uint m_nCamSyncEvents;
	public double m_flReferenceCamSyncTime;
	public double m_flFrameElapsedTime;
	public double m_flFrameDeliveryRate;
	public double m_flFrameCaptureTime_DriverAbsolute;
	public double m_flFrameCaptureTime_ServerRelative;
	public ulong m_nFrameCaptureTicks_ServerAbsolute;
	public double m_flFrameCaptureTime_ClientRelative;
	[MarshalAs(UnmanagedType.I1)]
	public bool m_bPoseIsValid;
	public HmdMatrix34_t m_matDeviceToAbsoluteTracking;
	public float m_Pad0; //float[4]
	public float m_Pad1;
	public float m_Pad2;
	public float m_Pad3;
	public IntPtr m_pImageData; // void *
}
[StructLayout(LayoutKind.Sequential)] public struct COpenVRContext
{
	public IntPtr m_pVRSystem; // class vr::IVRSystem *
	public IntPtr m_pVRChaperone; // class vr::IVRChaperone *
	public IntPtr m_pVRChaperoneSetup; // class vr::IVRChaperoneSetup *
	public IntPtr m_pVRCompositor; // class vr::IVRCompositor *
	public IntPtr m_pVROverlay; // class vr::IVROverlay *
	public IntPtr m_pVRRenderModels; // class vr::IVRRenderModels *
	public IntPtr m_pVRExtendedDisplay; // class vr::IVRExtendedDisplay *
	public IntPtr m_pVRSettings; // class vr::IVRSettings *
	public IntPtr m_pVRApplications; // class vr::IVRApplications *
}

public class OpenVR
{

	public static uint InitInternal(ref EVRInitError peError, EVRApplicationType eApplicationType)
	{
		return OpenVRInterop.InitInternal(ref peError, eApplicationType);
	}

	public static void ShutdownInternal()
	{
		OpenVRInterop.ShutdownInternal();
	}

	public static bool IsHmdPresent()
	{
		return OpenVRInterop.IsHmdPresent();
	}

	public static bool IsRuntimeInstalled()
	{
		return OpenVRInterop.IsRuntimeInstalled();
	}

	public static string GetStringForHmdError(EVRInitError error)
	{
		return Marshal.PtrToStringAnsi(OpenVRInterop.GetStringForHmdError(error));
	}

	public static IntPtr GetGenericInterface(string pchInterfaceVersion, ref EVRInitError peError)
	{
		return OpenVRInterop.GetGenericInterface(pchInterfaceVersion, ref peError);
	}

	public static bool IsInterfaceVersionValid(string pchInterfaceVersion)
	{
		return OpenVRInterop.IsInterfaceVersionValid(pchInterfaceVersion);
	}

	public static uint GetInitToken()
	{
		return OpenVRInterop.GetInitToken();
	}

	public const uint k_unTrackingStringSize = 32;
	public const uint k_unMaxDriverDebugResponseSize = 32768;
	public const uint k_unTrackedDeviceIndex_Hmd = 0;
	public const uint k_unMaxTrackedDeviceCount = 16;
	public const uint k_unTrackedDeviceIndexInvalid = 4294967295;
	public const uint k_unMaxPropertyStringSize = 32768;
	public const uint k_unControllerStateAxisCount = 5;
	public const ulong k_ulOverlayHandleInvalid = 0;
	public const string IVRSystem_Version = "IVRSystem_011";
	public const string IVRExtendedDisplay_Version = "IVRExtendedDisplay_001";
	public const uint k_unMaxApplicationKeyLength = 128;
	public const string IVRApplications_Version = "IVRApplications_004";
	public const string IVRChaperone_Version = "IVRChaperone_003";
	public const string IVRChaperoneSetup_Version = "IVRChaperoneSetup_005";
	public const string IVRCompositor_Version = "IVRCompositor_013";
	public const uint k_unVROverlayMaxKeyLength = 128;
	public const uint k_unVROverlayMaxNameLength = 128;
	public const uint k_unMaxOverlayCount = 32;
	public const string IVROverlay_Version = "IVROverlay_010";
	public const string k_pch_Controller_Component_GDC2015 = "gdc2015";
	public const string k_pch_Controller_Component_Base = "base";
	public const string k_pch_Controller_Component_Tip = "tip";
	public const string k_pch_Controller_Component_HandGrip = "handgrip";
	public const string k_pch_Controller_Component_Status = "status";
	public const string IVRRenderModels_Version = "IVRRenderModels_005";
	public const uint k_unNotificationTextMaxSize = 256;
	public const string IVRNotifications_Version = "IVRNotifications_002";
	public const uint k_unMaxSettingsKeyLength = 128;
	public const string k_pch_SteamVR_Section = "steamvr";
	public const string k_pch_SteamVR_RequireHmd_String = "requireHmd";
	public const string k_pch_SteamVR_ForcedDriverKey_String = "forcedDriver";
	public const string k_pch_SteamVR_ForcedHmdKey_String = "forcedHmd";
	public const string k_pch_SteamVR_DisplayDebug_Bool = "displayDebug";
	public const string k_pch_SteamVR_DebugProcessPipe_String = "debugProcessPipe";
	public const string k_pch_SteamVR_EnableDistortion_Bool = "enableDistortion";
	public const string k_pch_SteamVR_DisplayDebugX_Int32 = "displayDebugX";
	public const string k_pch_SteamVR_DisplayDebugY_Int32 = "displayDebugY";
	public const string k_pch_SteamVR_SendSystemButtonToAllApps_Bool = "sendSystemButtonToAllApps";
	public const string k_pch_SteamVR_LogLevel_Int32 = "loglevel";
	public const string k_pch_SteamVR_IPD_Float = "ipd";
	public const string k_pch_SteamVR_Background_String = "background";
	public const string k_pch_SteamVR_GridColor_String = "gridColor";
	public const string k_pch_SteamVR_PlayAreaColor_String = "playAreaColor";
	public const string k_pch_SteamVR_ActivateMultipleDrivers_Bool = "activateMultipleDrivers";
	public const string k_pch_SteamVR_PowerOffOnExit_Bool = "powerOffOnExit";
	public const string k_pch_SteamVR_StandbyAppRunningTimeout_Float = "standbyAppRunningTimeout";
	public const string k_pch_SteamVR_StandbyNoAppTimeout_Float = "standbyNoAppTimeout";
	public const string k_pch_SteamVR_DirectMode_Bool = "directMode";
	public const string k_pch_SteamVR_DirectModeEdidVid_Int32 = "directModeEdidVid";
	public const string k_pch_SteamVR_DirectModeEdidPid_Int32 = "directModeEdidPid";
	public const string k_pch_SteamVR_UsingSpeakers_Bool = "usingSpeakers";
	public const string k_pch_SteamVR_SpeakersForwardYawOffsetDegrees_Float = "speakersForwardYawOffsetDegrees";
	public const string k_pch_SteamVR_BaseStationPowerManagement_Bool = "basestationPowerManagement";
	public const string k_pch_Lighthouse_Section = "driver_lighthouse";
	public const string k_pch_Lighthouse_DisableIMU_Bool = "disableimu";
	public const string k_pch_Lighthouse_UseDisambiguation_String = "usedisambiguation";
	public const string k_pch_Lighthouse_DisambiguationDebug_Int32 = "disambiguationdebug";
	public const string k_pch_Lighthouse_PrimaryBasestation_Int32 = "primarybasestation";
	public const string k_pch_Lighthouse_LighthouseName_String = "lighthousename";
	public const string k_pch_Lighthouse_MaxIncidenceAngleDegrees_Float = "maxincidenceangledegrees";
	public const string k_pch_Lighthouse_UseLighthouseDirect_Bool = "uselighthousedirect";
	public const string k_pch_Lighthouse_DBHistory_Bool = "dbhistory";
	public const string k_pch_Lighthouse_OriginOffsetX_Float = "originoffsetx";
	public const string k_pch_Lighthouse_OriginOffsetY_Float = "originoffsety";
	public const string k_pch_Lighthouse_OriginOffsetZ_Float = "originoffsetz";
	public const string k_pch_Lighthouse_HeadingOffset_Float = "headingoffset";
	public const string k_pch_Null_Section = "driver_null";
	public const string k_pch_Null_EnableNullDriver_Bool = "enable";
	public const string k_pch_Null_SerialNumber_String = "serialNumber";
	public const string k_pch_Null_ModelNumber_String = "modelNumber";
	public const string k_pch_Null_WindowX_Int32 = "windowX";
	public const string k_pch_Null_WindowY_Int32 = "windowY";
	public const string k_pch_Null_WindowWidth_Int32 = "windowWidth";
	public const string k_pch_Null_WindowHeight_Int32 = "windowHeight";
	public const string k_pch_Null_RenderWidth_Int32 = "renderWidth";
	public const string k_pch_Null_RenderHeight_Int32 = "renderHeight";
	public const string k_pch_Null_SecondsFromVsyncToPhotons_Float = "secondsFromVsyncToPhotons";
	public const string k_pch_Null_DisplayFrequency_Float = "displayFrequency";
	public const string k_pch_UserInterface_Section = "userinterface";
	public const string k_pch_UserInterface_StatusAlwaysOnTop_Bool = "StatusAlwaysOnTop";
	public const string k_pch_Notifications_Section = "notifications";
	public const string k_pch_Notifications_DoNotDisturb_Bool = "DoNotDisturb";
	public const string k_pch_Keyboard_Section = "keyboard";
	public const string k_pch_Keyboard_TutorialCompletions = "TutorialCompletions";
	public const string k_pch_Perf_Section = "perfcheck";
	public const string k_pch_Perf_HeuristicActive_Bool = "heuristicActive";
	public const string k_pch_Perf_NotifyInHMD_Bool = "warnInHMD";
	public const string k_pch_Perf_NotifyOnlyOnce_Bool = "warnOnlyOnce";
	public const string k_pch_Perf_AllowTimingStore_Bool = "allowTimingStore";
	public const string k_pch_Perf_SaveTimingsOnExit_Bool = "saveTimingsOnExit";
	public const string k_pch_Perf_TestData_Float = "perfTestData";
	public const string k_pch_Camera_Section = "camera";
	public const string IVRSettings_Version = "IVRSettings_001";
	public const string k_pch_audio_Section = "audio";
	public const string k_pch_audio_OnPlaybackDevice_String = "onPlaybackDevice";
	public const string k_pch_audio_OnRecordDevice_String = "onRecordDevice";
	public const string k_pch_audio_OffPlaybackDevice_String = "offPlaybackDevice";
	public const string k_pch_audio_OffRecordDevice_String = "offRecordDevice";
	public const string k_pch_audio_VIVEHDMIGain = "viveHDMIGain";
	public const string IVRTrackedCamera_Version = "IVRTrackedCamera_001";

	static uint VRToken { get; set; }

	const string FnTable_Prefix = "FnTable:";

	class COpenVRContext
	{
		public COpenVRContext() { Clear(); }

		public void Clear()
		{
			m_pVRSystem = null;
			m_pVRChaperone = null;
			m_pVRChaperoneSetup = null;
			m_pVRCompositor = null;
			m_pVROverlay = null;
			m_pVRRenderModels = null;
			m_pVRExtendedDisplay = null;
			m_pVRSettings = null;
			m_pVRApplications = null;
		}

		void CheckClear()
		{
			if (VRToken != GetInitToken())
			{
				Clear();
				VRToken = GetInitToken();
			}
		}

		public CVRSystem VRSystem()
		{
			CheckClear();
			if (m_pVRSystem == null)
			{
				var eError = EVRInitError.None;
				var pInterface = OpenVRInterop.GetGenericInterface(FnTable_Prefix+IVRSystem_Version, ref eError);
				if (pInterface != IntPtr.Zero && eError == EVRInitError.None)
					m_pVRSystem = new CVRSystem(pInterface);
			}
			return m_pVRSystem;
		}

		public CVRChaperone VRChaperone()
		{
			CheckClear();
			if (m_pVRChaperone == null)
			{
				var eError = EVRInitError.None;
				var pInterface = OpenVRInterop.GetGenericInterface(FnTable_Prefix+IVRChaperone_Version, ref eError);
				if (pInterface != IntPtr.Zero && eError == EVRInitError.None)
					m_pVRChaperone = new CVRChaperone(pInterface);
			}
			return m_pVRChaperone;
		}

		public CVRChaperoneSetup VRChaperoneSetup()
		{
			CheckClear();
			if (m_pVRChaperoneSetup == null)
			{
				var eError = EVRInitError.None;
				var pInterface = OpenVRInterop.GetGenericInterface(FnTable_Prefix+IVRChaperoneSetup_Version, ref eError);
				if (pInterface != IntPtr.Zero && eError == EVRInitError.None)
					m_pVRChaperoneSetup = new CVRChaperoneSetup(pInterface);
			}
			return m_pVRChaperoneSetup;
		}

		public CVRCompositor VRCompositor()
		{
			CheckClear();
			if (m_pVRCompositor == null)
			{
				var eError = EVRInitError.None;
				var pInterface = OpenVRInterop.GetGenericInterface(FnTable_Prefix+IVRCompositor_Version, ref eError);
				if (pInterface != IntPtr.Zero && eError == EVRInitError.None)
					m_pVRCompositor = new CVRCompositor(pInterface);
			}
			return m_pVRCompositor;
		}

		public CVROverlay VROverlay()
		{
			CheckClear();
			if (m_pVROverlay == null)
			{
				var eError = EVRInitError.None;
				var pInterface = OpenVRInterop.GetGenericInterface(FnTable_Prefix+IVROverlay_Version, ref eError);
				if (pInterface != IntPtr.Zero && eError == EVRInitError.None)
					m_pVROverlay = new CVROverlay(pInterface);
			}
			return m_pVROverlay;
		}

		public CVRRenderModels VRRenderModels()
		{
			CheckClear();
			if (m_pVRRenderModels == null)
			{
				var eError = EVRInitError.None;
				var pInterface = OpenVRInterop.GetGenericInterface(FnTable_Prefix+IVRRenderModels_Version, ref eError);
				if (pInterface != IntPtr.Zero && eError == EVRInitError.None)
					m_pVRRenderModels = new CVRRenderModels(pInterface);
			}
			return m_pVRRenderModels;
		}

		public CVRExtendedDisplay VRExtendedDisplay()
		{
			CheckClear();
			if (m_pVRExtendedDisplay == null)
			{
				var eError = EVRInitError.None;
				var pInterface = OpenVRInterop.GetGenericInterface(FnTable_Prefix+IVRExtendedDisplay_Version, ref eError);
				if (pInterface != IntPtr.Zero && eError == EVRInitError.None)
					m_pVRExtendedDisplay = new CVRExtendedDisplay(pInterface);
			}
			return m_pVRExtendedDisplay;
		}

		public CVRSettings VRSettings()
		{
			CheckClear();
			if (m_pVRSettings == null)
			{
				var eError = EVRInitError.None;
				var pInterface = OpenVRInterop.GetGenericInterface(FnTable_Prefix+IVRSettings_Version, ref eError);
				if (pInterface != IntPtr.Zero && eError == EVRInitError.None)
					m_pVRSettings = new CVRSettings(pInterface);
			}
			return m_pVRSettings;
		}

		public CVRApplications VRApplications()
		{
			CheckClear();
			if (m_pVRApplications == null)
			{
				var eError = EVRInitError.None;
				var pInterface = OpenVRInterop.GetGenericInterface(FnTable_Prefix+IVRApplications_Version, ref eError);
				if (pInterface != IntPtr.Zero && eError == EVRInitError.None)
					m_pVRApplications = new CVRApplications(pInterface);
			}
			return m_pVRApplications;
		}

		private CVRSystem m_pVRSystem;
		private CVRChaperone m_pVRChaperone;
		private CVRChaperoneSetup m_pVRChaperoneSetup;
		private CVRCompositor m_pVRCompositor;
		private CVROverlay m_pVROverlay;
		private CVRRenderModels m_pVRRenderModels;
		private CVRExtendedDisplay m_pVRExtendedDisplay;
		private CVRSettings m_pVRSettings;
		private CVRApplications m_pVRApplications;
	};

	private static COpenVRContext _OpenVRInternal_ModuleContext = null;
	static COpenVRContext OpenVRInternal_ModuleContext
	{
		get
		{
			if (_OpenVRInternal_ModuleContext == null)
				_OpenVRInternal_ModuleContext = new COpenVRContext();
			return _OpenVRInternal_ModuleContext;
		}
	}

	public static CVRSystem System { get { return OpenVRInternal_ModuleContext.VRSystem(); } }
	public static CVRChaperone Chaperone { get { return OpenVRInternal_ModuleContext.VRChaperone(); } }
	public static CVRChaperoneSetup ChaperoneSetup { get { return OpenVRInternal_ModuleContext.VRChaperoneSetup(); } }
	public static CVRCompositor Compositor { get { return OpenVRInternal_ModuleContext.VRCompositor(); } }
	public static CVROverlay Overlay { get { return OpenVRInternal_ModuleContext.VROverlay(); } }
	public static CVRRenderModels RenderModels { get { return OpenVRInternal_ModuleContext.VRRenderModels(); } }
	public static CVRApplications Applications { get { return OpenVRInternal_ModuleContext.VRApplications(); } }
	public static CVRSettings Settings { get { return OpenVRInternal_ModuleContext.VRSettings(); } }
	public static CVRExtendedDisplay ExtendedDisplay { get { return OpenVRInternal_ModuleContext.VRExtendedDisplay(); } }

	/** Finds the active installation of vrclient.dll and initializes it */
	public static CVRSystem Init(ref EVRInitError peError, EVRApplicationType eApplicationType = EVRApplicationType.VRApplication_Scene)
	{
		VRToken = InitInternal(ref peError, eApplicationType);
		OpenVRInternal_ModuleContext.Clear();

		if (peError != EVRInitError.None)
			return null;

		bool bInterfaceValid = IsInterfaceVersionValid(IVRSystem_Version);
		if (!bInterfaceValid)
		{
			ShutdownInternal();
			peError = EVRInitError.Init_InterfaceNotFound;
			return null;
		}

		return OpenVR.System;
	}

	/** unloads vrclient.dll. Any interface pointers from the interface are
	* invalid after this point */
	public static void Shutdown()
	{
		ShutdownInternal();
	}

}



}

#endif
