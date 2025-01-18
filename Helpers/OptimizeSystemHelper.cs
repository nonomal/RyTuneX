﻿using Microsoft.Win32;

namespace RyTuneX.Helpers;
internal class OptimizeSystemHelper
{
    public static async void DisableMenuShowDelay()
    {
        await OptimizationOptions.StartInCmd("reg add \"HKEY_CURRENT_USER\\Control Panel\\Desktop\" /v MenuShowDelay /t REG_SZ /d 0 /f");
    }

    public static async void DisableMouseHoverTime()
    {
        await OptimizationOptions.StartInCmd("reg add \"HKEY_CURRENT_USER\\Control Panel\\Mouse\" /v MouseHoverTime /t REG_SZ /d 0 /f");
    }

    public static async void DisableBackgroundApps()
    {
        await OptimizationOptions.StartInCmd("reg add \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\" /v GlobalUserDisabled /t REG_DWORD /d 1 /f");
    }

    public static async void EnableAutoComplete()
    {
        await OptimizationOptions.StartInCmd("reg add \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete\" /v \"Append Completion\" /t REG_SZ /d yes /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete\" /v AutoSuggest /t REG_SZ /d yes /f");
    }

    public static async void EnableCrashDump()
    {
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\CrashControl\" /v CrashDumpEnabled /t REG_DWORD /d 3 /f");
    }

    public static async void DisableRemoteAssistance()
    {
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Control\\Remote Assistance\" /v fAllowToGetHelp /t REG_DWORD /d 0 /f");
    }

    public static async void DisableWindowShake()
    {
        await OptimizationOptions.StartInCmd("reg add \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\" /v DisallowShaking /t REG_DWORD /d 1 /f");
    }

    public static async void AddCopyMoveContextMenu()
    {
        await OptimizationOptions.StartInCmd("reg add \"HKEY_CLASSES_ROOT\\AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Copy To\" /ve /d \"{C2FBB630-2971-11D1-A18C-00C04FD75D13}\" /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_CLASSES_ROOT\\AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Move To\" /ve /d \"{C2FBB631-2971-11D1-A18C-00C04FD75D13}\" /f");
    }

    public static async void AdjustTaskTimeouts()
    {
        await OptimizationOptions.StartInCmd("reg add \"HKEY_CURRENT_USER\\Control Panel\\Desktop\" /v AutoEndTasks /t REG_SZ /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_CURRENT_USER\\Control Panel\\Desktop\" /v HungAppTimeout /t REG_SZ /d 1000 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_CURRENT_USER\\Control Panel\\Desktop\" /v WaitToKillAppTimeout /t REG_SZ /d 2000 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_CURRENT_USER\\Control Panel\\Desktop\" /v LowLevelHooksTimeout /t REG_SZ /d 1000 /f");
    }

    public static async void EnableLowDiskSpaceChecks()
    {
        await OptimizationOptions.StartInCmd("reg add \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\" /v NoLowDiskSpaceChecks /t REG_DWORD /d 00000001 /f");
    }

    public static async void DisableLinkResolve()
    {
        await OptimizationOptions.StartInCmd("reg add \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\" /v LinkResolveIgnoreLinkInfo /t REG_DWORD /d 00000001 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\" /v NoResolveSearch /t REG_DWORD /d 00000001 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\" /v NoResolveTrack /t REG_DWORD /d 00000001 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\" /v NoInternetOpenWith /t REG_DWORD /d 00000001 /f");
    }

    public static async void DecreaseServiceTimeouts()
    {
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\" /v WaitToKillServiceTimeout /t REG_SZ /d 2000 /f");
    }

    public static async void DisableRemoteRegistry()
    {
        await OptimizationOptions.StartInCmd("sc config \"RemoteRegistry\" start= disabled");
    }

    public static async void HideFileExtensionsAndHiddenFiles()
    {
        await OptimizationOptions.StartInCmd("reg add \"HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\" /v HideFileExt /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\" /v Hidden /t REG_DWORD /d 1 /f");
    }

    public static async void OptimizeSystemProfile()
    {
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\" /v SystemResponsiveness /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\" /v NoLazyMode /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\" /v AlwaysOn /t REG_DWORD /d 1 /f");
    }

    public static async void SetGPUAndPrioritySettings()
    {
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games\" /v \"GPU Priority\" /t REG_DWORD /d 8 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games\" /v Priority /t REG_DWORD /d 6 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games\" /v \"Scheduling Category\" /t REG_SZ /d High /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games\" /v \"SFIO Priority\" /t REG_SZ /d High /f");
    }

    public static async void DisableFrameServerMode()
    {
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\Microsoft\\Windows Media Foundation\" /v EnableFrameServerMode /t REG_DWORD /d 0 /f");
    }

    public static async void SetLowLatencyGPUSettings()
    {
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency\" /v \"GPU Priority\" /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency\" /v Priority /t REG_DWORD /d 8 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency\" /v \"Scheduling Category\" /t REG_SZ /d Medium /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency\" /v \"SFIO Priority\" /t REG_SZ /d High /f");
    }

    public static async void SetNonBestEffortLimit()
    {
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Psched\" /v NonBestEffortLimit /t REG_DWORD /d 0 /f");
    }

    public static async void EnableMenuShowDelay()
    {
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_CURRENT_USER\\Control Panel\\Desktop\" /v MenuShowDelay /f");
    }

    public static async void EnableMouseHoverTime()
    {
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_CURRENT_USER\\Control Panel\\Mouse\" /v MouseHoverTime /f");
    }

    public static async void EnableBackgroundApps()
    {
        await OptimizationOptions.StartInCmd("reg add \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications\" /v GlobalUserDisabled /t REG_DWORD /d 0 /f");
    }

    public static async void DisableAutoComplete()
    {
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete\" /v \"Append Completion\" /f");
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete\" /v AutoSuggest /f");
    }

    public static async void DisableCrashDump()
    {
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\CrashControl\" /v CrashDumpEnabled /f");
    }

    public static async void EnableRemoteAssistance()
    {
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Control\\Remote Assistance\" /v fAllowToGetHelp /f");
    }

    public static async void EnableWindowShake()
    {
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\" /v DisallowShaking /f");
    }

    public static async void RemoveCopyMoveContextMenu()
    {
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_CLASSES_ROOT\\AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Copy To\" /f");
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_CLASSES_ROOT\\AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Move To\" /f");
    }

    public static async void IncreaseTaskTimeouts()
    {
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_CURRENT_USER\\Control Panel\\Desktop\" /v AutoEndTasks /f");
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_CURRENT_USER\\Control Panel\\Desktop\" /v HungAppTimeout /f");
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_CURRENT_USER\\Control Panel\\Desktop\" /v WaitToKillAppTimeout /f");
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_CURRENT_USER\\Control Panel\\Desktop\" /v LowLevelHooksTimeout /f");
    }

    public static async void DisableLowDiskSpaceChecks()
    {
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\" /v NoLowDiskSpaceChecks /f");
    }

    public static async void EnableLinkResolve()
    {
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\" /v LinkResolveIgnoreLinkInfo /f");
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\" /v NoResolveSearch /f");
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\" /v NoResolveTrack /f");
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\" /v NoInternetOpenWith /f");
    }

    public static async void RevertServiceTimeouts()
    {
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\" /v WaitToKillServiceTimeout /f");
    }

    public static async void EnableRemoteRegistry()
    {
        await OptimizationOptions.StartInCmd("sc config \"RemoteRegistry\" start= demand");
    }

    public static async void ShowFileExtensionsAndHiddenFiles()
    {
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\" /v HideFileExt /f");
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\" /v Hidden /f");
    }

    public static async void RevertSystemProfile()
    {
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\" /v SystemResponsiveness /f");
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\" /v NoLazyMode /f");
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\" /v AlwaysOn /f");
    }

    public static async void RevertGPUAndPrioritySettings()
    {
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games\" /v \"GPU Priority\" /f");
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games\" /v Priority /f");
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games\" /v \"Scheduling Category\" /f");
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games\" /v \"SFIO Priority\" /f");
    }

    public static async void EnableFrameServerMode()
    {
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\Microsoft\\Windows Media Foundation\" /v EnableFrameServerMode /f");
    }

    public static async void RevertLowLatencyGPUSettings()
    {
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency\" /v \"GPU Priority\" /f");
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency\" /v Priority /f");
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency\" /v \"Scheduling Category\" /f");
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency\" /v \"SFIO Priority\" /f");
    }

    public static async void RevertNonBestEffortLimit()
    {
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Psched\" /v NonBestEffortLimit /f");
    }

    internal static async void DisableTelemetryServices()
    {
        OptimizationOptions.StopService("DiagTrack");
        OptimizationOptions.StopService("diagnosticshub.standardcollector.service");
        OptimizationOptions.StopService("dmwappushservice");
        OptimizationOptions.StopService("DcpSvc");

        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DiagTrack\" /v Start /t REG_DWORD /d 4 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagnosticshub.standardcollector.service\" /v Start /t REG_DWORD /d 4 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\dmwappushservice\" /v Start /t REG_DWORD /d 4 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DcpSvc\" /v Start /t REG_DWORD /d 4 /f");

        await OptimizationOptions.StartInCmd("reg add \"HKLM\\Software\\Microsoft\\PolicyManager\\default\\WiFi\\AllowAutoConnectToWiFiSenseHotspots\" /v value /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKLM\\Software\\Microsoft\\PolicyManager\\default\\WiFi\\AllowWiFiHotSpotReporting\" /v value /t REG_DWORD /d 0 /f");

        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat\" /v DisableEngine /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat\" /v SbEnable /t REG_DWORD /d 0 /f");

        if (Environment.Is64BitOperatingSystem)
        {
            await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Policies\\Microsoft\\Windows\\AppCompat\" /v DisableEngine /t REG_DWORD /d 1 /f");
            await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Policies\\Microsoft\\Windows\\AppCompat\" /v SbEnable /t REG_DWORD /d 0 /f");
            await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Policies\\Microsoft\\Windows\\AppCompat\" /v DisablePCA /t REG_DWORD /d 1 /f");
        }

        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\System\" /v PublishUserActivities /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\SQMClient\\Windows\" /v CEIPEnable /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat\" /v AITEnable /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat\" /v DisableInventory /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat\" /v DisablePCA /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat\" /v DisableUAR /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Device Metadata\" /v PreventDeviceMetadataFromNetwork /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\MRT\" /v DontOfferThroughWUAU /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\WMI\\AutoLogger\\SQMLogger\" /v Start /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\PolicyManager\\current\\device\\System\" /v AllowExperimentation /d 0 /f");
        await OptimizationOptions.StartInCmd("sc config WdiServiceHost start= disabled");


    }

    internal static async void EnableTelemetryServices()
    {
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DiagTrack\" /v Start /t REG_DWORD /d 2 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagnosticshub.standardcollector.service\" /v Start /t REG_DWORD /d 2 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\dmwappushservice\" /v Start /t REG_DWORD /d 2 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DcpSvc\" /v Start /t REG_DWORD /d 2 /f");

        await OptimizationOptions.StartInCmd("sc config WdiSystemHost start= auto");
        await OptimizationOptions.StartInCmd("sc config WdiServiceHost start= auto");

        await OptimizationOptions.StartInCmd("sc start DiagTrack");
        await OptimizationOptions.StartInCmd("sc start diagnosticshub.standardcollector.service");
        await OptimizationOptions.StartInCmd("sc start dmwappushservice");
        await OptimizationOptions.StartInCmd("sc start DcpSvc");

    }

    internal static async void DisableMediaPlayerSharing()
    {
        OptimizationOptions.StopService("WMPNetworkSvc");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\WMPNetworkSvc\" /v Start /t REG_DWORD /d 4 /f");

    }

    internal static async void EnableMediaPlayerSharing()
    {
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\WMPNetworkSvc\" /v Start /t REG_DWORD /d 2 /f");
        await OptimizationOptions.StartInCmd("sc start WMPNetworkSvc");

    }

    internal static async void DisableHomeGroup()
    {
        OptimizationOptions.StopService("HomeGroupListener");
        OptimizationOptions.StopService("HomeGroupProvider");

        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\HomeGroup\" /v DisableHomeGroup /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\HomeGroupListener\" /v Start /t REG_DWORD /d 4 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\HomeGroupProvider\" /v Start /t REG_DWORD /d 4 /f");

    }

    internal static async void EnableHomeGroup()
    {
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\HomeGroupListener\" /v Start /t REG_DWORD /d 2 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\HomeGroupProvider\" /v Start /t REG_DWORD /d 2 /f");
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\HomeGroup\" /v DisableHomeGroup /f");
        await OptimizationOptions.StartInCmd("sc start HomeGroupListener");
        await OptimizationOptions.StartInCmd("sc start HomeGroupProvider");
    }

    internal static async void DisablePrintService()
    {
        OptimizationOptions.StopService("Spooler");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Spooler\" /v Start /t REG_DWORD /d 3 /f");
    }

    internal static async void EnablePrintService()
    {
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Spooler\" /v Start /t REG_DWORD /d 2 /f");
        await OptimizationOptions.StartInCmd("cmd /c sc start Spooler");
    }

    internal static async void DisableSysMain()
    {
        OptimizationOptions.StopService("SysMain");

        await OptimizationOptions.StartInCmd("reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\SysMain\" /v Start /t REG_DWORD /d 4 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management\\PrefetchParameters\" /v EnableSuperfetch /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management\\PrefetchParameters\" /v EnablePrefetcher /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management\\PrefetchParameters\" /v SfTracingState /t REG_DWORD /d 1 /f");
    }

    internal static async void EnableSysMain()
    {
        await OptimizationOptions.StartInCmd("reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\SysMain\" /v Start /t REG_DWORD /d 2 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management\\PrefetchParameters\" /v EnableSuperfetch /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management\\PrefetchParameters\" /v EnablePrefetcher /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg delete \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management\\PrefetchParameters\" /v SfTracingState /f");

        OptimizationOptions.StartService("SysMain");
    }

    internal static async void EnableCompatibilityAssistant()
    {
        await OptimizationOptions.StartInCmd("reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\PcaSvc\" /v Start /t REG_DWORD /d 2 /f");
        OptimizationOptions.StartService("PcaSvc");
    }

    internal static async void DisableCompatibilityAssistant()
    {
        OptimizationOptions.StopService("PcaSvc");
        await OptimizationOptions.StartInCmd("reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\PcaSvc\" /v Start /t REG_DWORD /d 4 /f");
    }

    internal static async void EnableVerboseLogon()
    {
        await OptimizationOptions.StartInCmd("reg add \"HKLM\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\" /v VerboseStatus /t REG_DWORD /d 1 /f");
    }

    internal static async void DisableVerboseLogon()
    {
        await OptimizationOptions.StartInCmd("reg add \"HKLM\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\" /v VerboseStatus /t REG_DWORD /d 0 /f");
    }

    internal static async void EnableClassicContextMenu()
    {
        await OptimizationOptions.StartInCmd("reg add \"HKCU\\Software\\Classes\\CLSID\\{86ca1aa0-34aa-4e8b-a509-50c905bae2a2}\\InprocServer32\" /f");
        await OptimizationOptions.StartInCmd("taskkill /F /IM explorer.exe & start explorer");
    }

    internal static async void DisableClassicContextMenu()
    {
        await OptimizationOptions.StartInCmd("reg delete \"HKCU\\Software\\Classes\\CLSID\\{86ca1aa0-34aa-4e8b-a509-50c905bae2a2}\" /f");
        await OptimizationOptions.StartInCmd("taskkill /F /IM explorer.exe & start explorer");
    }

    internal static async void DisableSystemRestore()
    {
        await OptimizationOptions.StartInCmd("vssadmin delete shadows /for=c: /all /quiet");
        OptimizationOptions.StopService("VSS");

        await OptimizationOptions.StartInCmd("reg add \"HKLM\\SOFTWARE\\Policies\\Microsoft\\Windows NT\\SystemRestore\" /v DisableSR /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKLM\\SOFTWARE\\Policies\\Microsoft\\Windows NT\\SystemRestore\" /v DisableConfig /t REG_DWORD /d 1 /f");
    }

    internal static async void EnableSystemRestore()
    {
        await OptimizationOptions.StartInCmd("reg delete \"HKLM\\SOFTWARE\\Policies\\Microsoft\\Windows NT\\SystemRestore\" /v DisableSR /f");
        await OptimizationOptions.StartInCmd("reg delete \"HKLM\\SOFTWARE\\Policies\\Microsoft\\Windows NT\\SystemRestore\" /v DisableConfig /f");

        OptimizationOptions.StartService("VSS");
    }

    internal static async void DisableSearch()
    {
        OptimizationOptions.StopService("WSearch");
        await OptimizationOptions.StartInCmd("reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\WSearch\" /v Start /t REG_DWORD /d 4 /f");
    }

    internal static async void EnableSearch()
    {
        await OptimizationOptions.StartInCmd("reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\WSearch\" /v Start /t REG_DWORD /d 2 /f");
        OptimizationOptions.StartService("WSearch");
    }

    internal static async void DisableSMB(string v)
    {
        await OptimizationOptions.StartInCmd($"reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\LanmanServer\\Parameters\" /v SMB{v} /t REG_DWORD /d 0 /f");
    }

    internal static async void EnableSMB(string v)
    {
        await OptimizationOptions.StartInCmd($"reg delete \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\LanmanServer\\Parameters\" /v SMB{v} /f");
    }

    internal static async void DisableNTFSTimeStamp()
    {
        await OptimizationOptions.StartInCmd("fsutil behavior set disablelastaccess 1");
    }

    internal static async void EnableNTFSTimeStamp()
    {
        await OptimizationOptions.StartInCmd("fsutil behavior set disablelastaccess 2");
    }

    internal static async void DisableErrorReporting()
    {
        await OptimizationOptions.StartInCmd("reg add \"HKLM\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Error Reporting\" /v Disabled /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKLM\\SOFTWARE\\Policies\\Microsoft\\PCHealth\\ErrorReporting\" /v DoReport /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKLM\\SOFTWARE\\Microsoft\\Windows\\Windows Error Reporting\" /v Disabled /t REG_DWORD /d 1 /f");

        OptimizationOptions.StopService("WerSvc");
        OptimizationOptions.StopService("wercplsupport");
        await OptimizationOptions.StartInCmd("reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\WerSvc\" /v Start /t REG_DWORD /d 4 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\wercplsupport\" /v Start /t REG_DWORD /d 4 /f");
    }

    internal static async void EnableErrorReporting()
    {
        await OptimizationOptions.StartInCmd("reg delete \"HKLM\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Error Reporting\" /v Disabled /f");
        await OptimizationOptions.StartInCmd("reg delete \"HKLM\\SOFTWARE\\Policies\\Microsoft\\PCHealth\\ErrorReporting\" /v DoReport /f");
        await OptimizationOptions.StartInCmd("reg delete \"HKLM\\SOFTWARE\\Microsoft\\Windows\\Windows Error Reporting\" /v Disabled /f");

        await OptimizationOptions.StartInCmd("reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\wercplsupport\" /v Start /t REG_DWORD /d 3 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Services\\WerSvc\" /v Start /t REG_DWORD /d 2 /f");
        OptimizationOptions.StartService("WerSvc");
        OptimizationOptions.StartService("wercplsupport");
    }

    internal static async void EnableLegacyVolumeSlider()
    {
        await OptimizationOptions.StartInCmd("reg add \"HKLM\\Software\\Microsoft\\Windows NT\\CurrentVersion\\MTCUVC\" /v EnableMtcUvc /t REG_DWORD /d 0 /f");
    }

    internal static async void DisableLegacyVolumeSlider()
    {
        await OptimizationOptions.StartInCmd("reg add \"HKLM\\Software\\Microsoft\\Windows NT\\CurrentVersion\\MTCUVC\" /v EnableMtcUvc /t REG_DWORD /d 1 /f");
    }

    internal static async void DisableCortana()
    {
        await OptimizationOptions.StartInCmd("reg add \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\SearchSettings\" /v IsDeviceSearchHistoryEnabled /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKLM\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search\" /v AllowCortana /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKLM\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search\" /v DisableWebSearch /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKLM\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search\" /v ConnectedSearchUseWeb /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKLM\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search\" /v ConnectedSearchUseWebOverMeteredConnections /t REG_DWORD /d 0 /f");

        await OptimizationOptions.StartInCmd("reg add \"HKCU\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Search\" /v HistoryViewEnabled /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKCU\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Search\" /v DeviceHistoryEnabled /t REG_DWORD /d 0 /f");

        await OptimizationOptions.StartInCmd("reg add \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Search\" /v AllowSearchToUseLocation /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Search\" /v BingSearchEnabled /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Search\" /v CortanaConsent /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKLM\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search\" /v AllowCloudSearch /t REG_DWORD /d 0 /f");
    }

    internal static async void EnableCortana()
    {
        await OptimizationOptions.StartInCmd("reg add \"HKLM\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search\" /v AllowCortana /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKLM\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search\" /v DisableWebSearch /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKLM\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search\" /v ConnectedSearchUseWeb /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKLM\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search\" /v ConnectedSearchUseWebOverMeteredConnections /t REG_DWORD /d 1 /f");

        await OptimizationOptions.StartInCmd("reg add \"HKCU\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Search\" /v HistoryViewEnabled /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKCU\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Search\" /v DeviceHistoryEnabled /t REG_DWORD /d 1 /f");

        await OptimizationOptions.StartInCmd("reg add \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Search\" /v AllowSearchToUseLocation /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Search\" /v BingSearchEnabled /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Search\" /v CortanaConsent /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKLM\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search\" /v AllowCloudSearch /t REG_DWORD /d 1 /f");
    }

    internal static async void EnableGamingMode()
    {
        await OptimizationOptions.StartInCmd("reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers\" /v HwSchMode /t REG_DWORD /d 2 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKCU\\Software\\Microsoft\\GameBar\" /v AllowAutoGameMode /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKCU\\Software\\Microsoft\\GameBar\" /v AutoGameModeEnabled /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKCU\\System\\GameConfigStore\" /v GameDVR_FSEBehaviorMode /t REG_DWORD /d 2 /f");
    }

    internal static async void DisableGamingMode()
    {
        await OptimizationOptions.StartInCmd("reg add \"HKLM\\SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers\" /v HwSchMode /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKCU\\Software\\Microsoft\\GameBar\" /v AllowAutoGameMode /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKCU\\Software\\Microsoft\\GameBar\" /v AutoGameModeEnabled /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKCU\\System\\GameConfigStore\" /v GameDVR_FSEBehaviorMode /t REG_DWORD /d 0 /f");
    }


    internal static async void DisableAutomaticUpdates()
    {
        await OptimizationOptions.StartInCmd("reg add \"HKEY_USERS\\S-1-5-20\\Software\\Microsoft\\Windows\\CurrentVersion\\DeliveryOptimization\\Settings\" /v DownloadMode /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\WindowsUpdate\\UX\\Settings\" /v UxOption /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\WindowsUpdate\\AU\" /v NoAutoUpdate /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\WindowsUpdate\\AU\" /v AUOptions /t REG_DWORD /d 2 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\WindowsUpdate\\AU\" /v NoAutoRebootWithLoggedOnUsers /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\DeliveryOptimization\\Config\" /v DODownloadMode /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DoSvc\" /v Start /t REG_DWORD /d 4 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Speech\" /v AllowSpeechModelUpdate /t REG_DWORD /d 0 /f");

        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Schedule\\Maintenance\" /v MaintenanceDisabled /t REG_DWORD /d 1 /f");
        OptimizationOptions.StopService("DoSvc");
    }

    internal static async void EnableAutomaticUpdates()
    {
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_USERS\\S-1-5-20\\Software\\Microsoft\\Windows\\CurrentVersion\\DeliveryOptimization\\Settings\" /v DownloadMode /f");
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\WindowsUpdate\\UX\\Settings\" /v UxOption /f");
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\WindowsUpdate\\AU\" /v AUOptions /f");
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\WindowsUpdate\\AU\" /v NoAutoUpdate /f");
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\WindowsUpdate\\AU\" /v NoAutoRebootWithLoggedOnUsers /f");
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\DeliveryOptimization\\Config\" /v DODownloadMode /f");
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Speech\" /v AllowSpeechModelUpdate /f");

        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DoSvc\" /v Start /t REG_DWORD /d 3 /f");
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Schedule\\Maintenance\" /v MaintenanceDisabled /f");
    }

    internal static async void DisableStoreUpdates()
    {
        await OptimizationOptions.StartInCmd("reg add \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager\" /v SilentInstalledAppsEnabled /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\CloudContent\" /v DisableSoftLanding /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager\" /v PreInstalledAppsEnabled /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\CloudContent\" /v DisableWindowsConsumerFeatures /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager\" /v OemPreInstalledAppsEnabled /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\WindowsStore\" /v AutoDownload /t REG_DWORD /d 2 /f");
    }

    internal static async void EnableStoreUpdates()
    {
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager\" /v SilentInstalledAppsEnabled /f");
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\CloudContent\" /v DisableSoftLanding /f");
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager\" /v PreInstalledAppsEnabled /f");
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\CloudContent\" /v DisableWindowsConsumerFeatures /f");
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager\" /v OemPreInstalledAppsEnabled /f");
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\WindowsStore\" /v AutoDownload /f");
    }


    internal static async void DisableOneDrive()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\OneDrive /v DisableFileSyncNGSC /t REG_DWORD /d 1 /f");
    }

    internal static async void EnableOneDrive()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\OneDrive /v DisableFileSyncNGSC /t REG_DWORD /d 0 /f");
    }

    internal static async void EnableSensorServices()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\SensrSvc /v Start /t REG_DWORD /d 2 /f");
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\SensorService /v Start /t REG_DWORD /d 2 /f");
        await OptimizationOptions.StartInCmd("sc start SensrSvc");
        await OptimizationOptions.StartInCmd("sc start SensorService");
    }

    internal static async void DisableSensorServices()
    {
        await OptimizationOptions.StartInCmd("sc stop SensrSvc");
        await OptimizationOptions.StartInCmd("sc stop SensorService");
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\SensrSvc /v Start /t REG_DWORD /d 4 /f");
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\SensorService /v Start /t REG_DWORD /d 4 /f");
    }

    internal static async void DisableNewsAndInterests()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Feeds /v EnableFeeds /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\PolicyManager\\default\\NewsAndInterests\\AllowNewsAndInterests /v value /t REG_DWORD /d 0 /f");
    }

    internal static async void DisableSpotlightFeatures()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager /v RotatingLockScreenOverlayEnabled /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("REG ADD HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager /v RotatingLockScreenEnabled /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("REG ADD HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager /v DisableWindowsSpotlightFeatures /t REG_DWORD /d 1 /f");
    }

    internal static async void DisableTailoredExperiences()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager /v DisableTailoredExperiencesWithDiagnosticData /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("REG ADD HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Privacy /v TailoredExperiencesWithDiagnosticDataEnabled /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("REG ADD HKEY_USERS\\.DEFAULT\\Software\\Microsoft\\Windows\\CurrentVersion\\Privacy /v TailoredExperiencesWithDiagnosticDataEnabled /t REG_DWORD /d 0 /f");
    }

    internal static async void DisableCloudOptimizedContent()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\CloudContent /v DisableCloudOptimizedContent /t REG_DWORD /d 1 /f");
    }

    internal static async void DisableFeedbackNotifications()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\DataCollection /v DoNotShowFeedbackNotifications /t REG_DWORD /d 1 /f");
    }

    internal static async void DisableAdvertisingID()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\AdvertisingInfo /v Enabled /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AdvertisingInfo /v DisabledByGroupPolicy /t REG_DWORD /d 1 /f");
    }

    internal static async void DisableBluetoothAdvertising()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\PolicyManager\\current\\device\\Bluetooth /v AllowAdvertising /t REG_DWORD /d 0 /f");
    }

    internal static async void DisableAutomaticRestartSignOn()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v DisableAutomaticRestartSignOn /t REG_DWORD /d 1 /f");
    }

    internal static async void DisableHandwritingDataSharing()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\TabletPC /v PreventHandwritingDataSharing /t REG_DWORD /d 1 /f");
    }

    internal static async void DisableTextInputDataCollection()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\TextInput /v AllowLinguisticDataCollection /t REG_DWORD /d 0 /f");
    }

    internal static async void DisableInputPersonalization()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\InputPersonalization /v AllowInputPersonalization /t REG_DWORD /d 0 /f");
    }

    internal static async void DisableSafeSearchMode()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\SearchSettings /v SafeSearchMode /t REG_DWORD /d 0 /f");
    }

    internal static async void DisableActivityUploads()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\System /v UploadUserActivities /t REG_DWORD /d 0 /f");
    }

    internal static async void DisableClipboardSync()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\System /v AllowCrossDeviceClipboard /t REG_DWORD /d 0 /f");
    }

    internal static async void DisableMessageSync()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows\\Messaging /v AllowMessageSync /t REG_DWORD /d 0 /f");
    }

    internal static async void DisableSettingSync()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows\\SettingSync /v DisableCredentialsSettingSync /t REG_DWORD /d 2 /f");
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows\\SettingSync /v DisableCredentialsSettingSyncUserOverride /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows\\SettingSync /v DisableApplicationSettingSync /t REG_DWORD /d 2 /f");
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows\\SettingSync /v DisableApplicationSettingSyncUserOverride /t REG_DWORD /d 1 /f");
    }

    internal static async void DisableVoiceActivation()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppPrivacy /v LetAppsActivateWithVoice /t REG_DWORD /d 2 /f");
    }

    internal static async void DisableFindMyDevice()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\FindMyDevice /v AllowFindMyDevice /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Settings\\FindMyDevice /v LocationSyncEnabled /t REG_DWORD /d 0 /f");
    }

    internal static async void DisableActivityFeed()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\System /v EnableActivityFeed /t REG_DWORD /d 0 /f");
    }

    internal static async void DisableCdp()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\System /v EnableCdp /t REG_DWORD /d 0 /f");
    }
    internal static async void DisableDiagnosticsToast()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Diagnostics\\DiagTrack /v ShowedToastAtLevel /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("REG ADD HKEY_USERS\\.DEFAULT\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Diagnostics\\DiagTrack /v ShowedToastAtLevel /t REG_DWORD /d 1 /f");
    }

    internal static async void DisableOnlineSpeechPrivacy()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_CURRENT_USER\\Software\\Microsoft\\Speech_OneCore\\Settings\\OnlineSpeechPrivacy /v HasAccepted /t REG_DWORD /d 0 /f");
    }

    internal static async void DisableLocationFeatures()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\location /v Value /t REG_SZ /d Deny /f");
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\LocationAndSensors /v DisableLocation /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\LocationAndSensors /v DisableWindowsLocationProvider /t REG_DWORD /d 1 /f");
    }

    internal static async void EnableNewsAndInterests()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Feeds /v EnableFeeds /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\PolicyManager\\default\\NewsAndInterests\\AllowNewsAndInterests /v value /t REG_DWORD /d 1 /f");
    }

    internal static async void EnableSpotlightFeatures()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager /v RotatingLockScreenOverlayEnabled /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("REG ADD HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager /v RotatingLockScreenEnabled /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("REG ADD HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager /v DisableWindowsSpotlightFeatures /t REG_DWORD /d 0 /f");
    }

    internal static async void EnableTailoredExperiences()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager /v DisableTailoredExperiencesWithDiagnosticData /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("REG ADD HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Privacy /v TailoredExperiencesWithDiagnosticDataEnabled /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("REG ADD HKEY_USERS\\.DEFAULT\\Software\\Microsoft\\Windows\\CurrentVersion\\Privacy /v TailoredExperiencesWithDiagnosticDataEnabled /t REG_DWORD /d 1 /f");
    }

    internal static async void EnableCloudOptimizedContent()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\CloudContent /v DisableCloudOptimizedContent /t REG_DWORD /d 0 /f");
    }

    internal static async void EnableFeedbackNotifications()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\DataCollection /v DoNotShowFeedbackNotifications /t REG_DWORD /d 0 /f");
    }

    internal static async void EnableAdvertisingID()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\AdvertisingInfo /v Enabled /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AdvertisingInfo /v DisabledByGroupPolicy /t REG_DWORD /d 0 /f");
    }

    internal static async void EnableBluetoothAdvertising()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\PolicyManager\\current\\device\\Bluetooth /v AllowAdvertising /t REG_DWORD /d 1 /f");
    }

    internal static async void EnableAutomaticRestartSignOn()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v DisableAutomaticRestartSignOn /t REG_DWORD /d 0 /f");
    }

    internal static async void EnableHandwritingDataSharing()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\TabletPC /v PreventHandwritingDataSharing /t REG_DWORD /d 0 /f");
    }

    internal static async void EnableTextInputDataCollection()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\TextInput /v AllowLinguisticDataCollection /t REG_DWORD /d 1 /f");
    }

    internal static async void EnableInputPersonalization()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\InputPersonalization /v AllowInputPersonalization /t REG_DWORD /d 1 /f");
    }

    internal static async void EnableSafeSearchMode()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\SearchSettings /v SafeSearchMode /t REG_DWORD /d 1 /f");
    }

    internal static async void EnableActivityUploads()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\System /v UploadUserActivities /t REG_DWORD /d 1 /f");
    }

    internal static async void EnableClipboardSync()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\System /v AllowCrossDeviceClipboard /t REG_DWORD /d 1 /f");
    }

    internal static async void EnableMessageSync()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows\\Messaging /v AllowMessageSync /t REG_DWORD /d 1 /f");
    }

    internal static async void EnableSettingSync()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows\\SettingSync /v DisableCredentialsSettingSync /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows\\SettingSync /v DisableCredentialsSettingSyncUserOverride /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows\\SettingSync /v DisableApplicationSettingSync /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows\\SettingSync /v DisableApplicationSettingSyncUserOverride /t REG_DWORD /d 0 /f");
    }

    internal static async void EnableVoiceActivation()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppPrivacy /v LetAppsActivateWithVoice /t REG_DWORD /d 1 /f");
    }

    internal static async void EnableFindMyDevice()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\FindMyDevice /v AllowFindMyDevice /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Settings\\FindMyDevice /v LocationSyncEnabled /t REG_DWORD /d 1 /f");
    }

    internal static async void EnableActivityFeed()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\System /v EnableActivityFeed /t REG_DWORD /d 1 /f");
    }

    internal static async void EnableCdp()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\System /v EnableCdp /t REG_DWORD /d 1 /f");
    }

    internal static async void EnableDiagnosticsToast()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Diagnostics\\DiagTrack /v ShowedToastAtLevel /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("REG ADD HKEY_USERS\\.DEFAULT\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Diagnostics\\DiagTrack /v ShowedToastAtLevel /t REG_DWORD /d 0 /f");
    }

    internal static async void EnableOnlineSpeechPrivacy()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_CURRENT_USER\\Software\\Microsoft\\Speech_OneCore\\Settings\\OnlineSpeechPrivacy /v HasAccepted /t REG_DWORD /d 1 /f");
    }

    internal static async void EnableLocationFeatures()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\location /v Value /t REG_SZ /d Allow /f");
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\LocationAndSensors /v DisableLocation /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\LocationAndSensors /v DisableWindowsLocationProvider /t REG_DWORD /d 0 /f");
    }

    internal static async void DisableBiometrics()
    {
        await OptimizationOptions.StartInCmd("REG ADD HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Biometrics /v Enabled /t REG_DWORD /d 0 /f");
    }

    internal static async void EnableBiometrics()
    {
        await OptimizationOptions.StartInCmd("reg delete \"HKLM\\SOFTWARE\\Policies\\Microsoft\\Biometrics\" /v \"Enabled\" /f");
    }

    internal static async void DisableGameBar()
    {
        await OptimizationOptions.StartInCmd("reg add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\GameDVR /v AppCaptureEnabled /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\GameDVR /v AudioCaptureEnabled /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\GameDVR /v CursorCaptureEnabled /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add HKCU\\Software\\Microsoft\\GameBar /v UseNexusForGameBarEnabled /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add HKCU\\Software\\Microsoft\\GameBar /v ShowStartupPanel /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add HKCU\\System\\GameConfigStore /v GameDVR_Enabled /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add HKLM\\Software\\Policies\\Microsoft\\Windows\\GameDVR /v AllowGameDVR /t REG_DWORD /d 0 /f");
    }

    internal static async void EnableGameBar()
    {
        await OptimizationOptions.StartInCmd("reg add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\GameDVR /v AppCaptureEnabled /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\GameDVR /v AudioCaptureEnabled /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\GameDVR /v CursorCaptureEnabled /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add HKCU\\Software\\Microsoft\\GameBar /v UseNexusForGameBarEnabled /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add HKCU\\Software\\Microsoft\\GameBar /v ShowStartupPanel /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add HKCU\\System\\GameConfigStore /v GameDVR_Enabled /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add HKLM\\Software\\Policies\\Microsoft\\Windows\\GameDVR /v AllowGameDVR /t REG_DWORD /d 1 /f");
    }


    internal static async void DisableQuickAccessHistory()
    {
        await OptimizationOptions.StartInCmd("reg add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Feeds /v ShellFeedsTaskbarViewMode /t REG_DWORD /d 2 /f");
        await OptimizationOptions.StartInCmd("reg add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Feeds /v IsFeedsAvailable /t REG_DWORD /d 0 /f");

        await OptimizationOptions.StartInCmd("reg add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced /v ShowTaskViewButton /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\OperationStatusManager /v EnthusiastMode /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add HKCU\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced /v ShowSyncProviderNotifications /t REG_DWORD /d 0 /f");

        await OptimizationOptions.StartInCmd("reg add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer /v ShowFrequent /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer /v ShowRecent /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced /v LaunchTo /t REG_DWORD /d 1 /f");

        await OptimizationOptions.StartInCmd("reg add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer /v HideSCAMeetNow /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer /v HideSCAMeetNow /t REG_DWORD /d 1 /f");

        await OptimizationOptions.StartInCmd("reg add HKLM\\SOFTWARE\\Policies\\Microsoft\\Windows\\FileHistory /v Disabled /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add HKLM\\SOFTWARE\\Policies\\Microsoft\\Windows\\File History /v Disabled /t REG_DWORD /d 1 /f");
    }

    internal static async void EnableQuickAccessHistory()
    {
        await OptimizationOptions.StartInCmd("reg add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\OperationStatusManager /v EnthusiastMode /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add HKCU\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced /v ShowSyncProviderNotifications /t REG_DWORD /d 1 /f");

        await OptimizationOptions.StartInCmd("reg add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer /v ShowFrequent /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer /v ShowRecent /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced /v LaunchTo /t REG_DWORD /d 2 /f");
        await OptimizationOptions.StartInCmd("reg delete HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced /v ShowTaskViewButton /f");

        await OptimizationOptions.StartInCmd("reg delete HKLM\\SOFTWARE\\Policies\\Microsoft\\Windows\\FileHistory /v Disabled /f");
        await OptimizationOptions.StartInCmd("reg delete HKLM\\SOFTWARE\\Policies\\Microsoft\\Windows\\File History /v Disabled /f");

        await OptimizationOptions.StartInCmd("reg delete HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Search /v SearchboxTaskbarMode /f");
        await OptimizationOptions.StartInCmd("reg delete HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Feeds /v ShellFeedsTaskbarViewMode /f");
        await OptimizationOptions.StartInCmd("reg delete HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Feeds /v IsFeedsAvailable /f");

        await OptimizationOptions.StartInCmd("reg delete HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer /v HideSCAMeetNow /f");
        await OptimizationOptions.StartInCmd("reg delete HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer /v HideSCAMeetNow /f");
    }

    internal static async void DisableStartMenuAds()
    {
        await OptimizationOptions.StartInCmd("reg add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager /v SubscribedContent-88000326Enabled /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add HKCU\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\UserProfileEngagement /v ScoobeSystemSettingEnabled /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager /v ContentDeliveryAllowed /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager /v PreInstalledAppsEverEnabled /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager /v SilentInstalledAppsEnabled /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager /v SubscribedContent-314559Enabled /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager /v SubscribedContent-338387Enabled /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager /v SubscribedContent-338389Enabled /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager /v SystemPaneSuggestionsEnabled /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager /v SubscribedContent-338393Enabled /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager /v SubscribedContent-353694Enabled /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager /v SubscribedContent-353696Enabled /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager /v SubscribedContent-310093Enabled /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager /v SubscribedContent-338388Enabled /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager /v SubscribedContentEnabled /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager /v SoftLandingEnabled /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager /v FeatureManagementEnabled /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add HKCU\\Software\\Policies\\Microsoft\\Windows\\Explorer /v DisableSearchBoxSuggestions /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add HKLM\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer /v AllowOnlineTips /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add HKLM\\SOFTWARE\\Policies\\Microsoft\\Windows\\Explorer /v DisableSearchBoxSuggestions /t REG_DWORD /d 1 /f");
    }


    internal static async void EnableStartMenuAds()
    {
        await OptimizationOptions.StartInCmd("reg delete HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager /v SubscribedContent-88000326Enabled /f");
        await OptimizationOptions.StartInCmd("reg delete HKCU\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\UserProfileEngagement /v ScoobeSystemSettingEnabled /f");
        await OptimizationOptions.StartInCmd("reg delete HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager /v ContentDeliveryAllowed /f");
        await OptimizationOptions.StartInCmd("reg delete HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager /v PreInstalledAppsEverEnabled /f");
        await OptimizationOptions.StartInCmd("reg delete HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager /v SilentInstalledAppsEnabled /f");
        await OptimizationOptions.StartInCmd("reg delete HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager /v SubscribedContent-314559Enabled /f");
        await OptimizationOptions.StartInCmd("reg delete HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager /v SubscribedContent-338387Enabled /f");
        await OptimizationOptions.StartInCmd("reg delete HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager /v SubscribedContent-338389Enabled /f");
        await OptimizationOptions.StartInCmd("reg delete HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager /v SystemPaneSuggestionsEnabled /f");
        await OptimizationOptions.StartInCmd("reg delete HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager /v SubscribedContent-338393Enabled /f");
        await OptimizationOptions.StartInCmd("reg delete HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager /v SubscribedContent-353694Enabled /f");
        await OptimizationOptions.StartInCmd("reg delete HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager /v SubscribedContent-353696Enabled /f");
        await OptimizationOptions.StartInCmd("reg delete HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager /v SubscribedContent-310093Enabled /f");
        await OptimizationOptions.StartInCmd("reg delete HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager /v SubscribedContentEnabled /f");
        await OptimizationOptions.StartInCmd("reg delete HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager /v SubscribedContent-338388Enabled /f");
        await OptimizationOptions.StartInCmd("reg delete HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager /v SoftLandingEnabled /f");
        await OptimizationOptions.StartInCmd("reg delete HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager /v FeatureManagementEnabled /f");
        await OptimizationOptions.StartInCmd("reg delete HKCU\\Software\\Policies\\Microsoft\\Windows\\Explorer /v DisableSearchBoxSuggestions /f");
        await OptimizationOptions.StartInCmd("reg delete HKLM\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer /v AllowOnlineTips /f");
        await OptimizationOptions.StartInCmd("reg delete HKLM\\SOFTWARE\\Policies\\Microsoft\\Windows\\Explorer /v DisableSearchBoxSuggestions /f");
    }


    internal static async void DisableMyPeople()
    {
        await OptimizationOptions.StartInCmd("reg add HKCU\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\\People /v PeopleBand /t REG_DWORD /d 0 /f");
    }

    internal static async void EnableMyPeople()
    {
        await OptimizationOptions.StartInCmd("reg add HKCU\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\\People /v PeopleBand /t REG_DWORD /d 1 /f");
    }


    internal static async void ExcludeDrivers()
    {
        await OptimizationOptions.StartInCmd("reg add HKLM\\SOFTWARE\\Policies\\Microsoft\\Windows\\WindowsUpdate /v ExcludeWUDriversInQualityUpdate /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add HKLM\\SOFTWARE\\Microsoft\\WindowsUpdate\\UX\\Settings /v ExcludeWUDriversInQualityUpdate /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add HKLM\\SOFTWARE\\Microsoft\\PolicyManager\\default\\Update\\ExcludeWUDriversInQualityUpdate /v value /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add HKLM\\SOFTWARE\\Microsoft\\PolicyManager\\default\\Update /v ExcludeWUDriversInQualityUpdate /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add HKLM\\SOFTWARE\\Microsoft\\PolicyManager\\current\\device\\Update /v ExcludeWUDriversInQualityUpdate /t REG_DWORD /d 1 /f");
    }

    internal static async void IncludeDrivers()
    {
        await OptimizationOptions.StartInCmd("reg add HKLM\\SOFTWARE\\Policies\\Microsoft\\Windows\\WindowsUpdate /v ExcludeWUDriversInQualityUpdate /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add HKLM\\SOFTWARE\\Microsoft\\WindowsUpdate\\UX\\Settings /v ExcludeWUDriversInQualityUpdate /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add HKLM\\SOFTWARE\\Microsoft\\PolicyManager\\default\\Update\\ExcludeWUDriversInQualityUpdate /v value /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add HKLM\\SOFTWARE\\Microsoft\\PolicyManager\\default\\Update /v ExcludeWUDriversInQualityUpdate /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add HKLM\\SOFTWARE\\Microsoft\\PolicyManager\\current\\device\\Update /v ExcludeWUDriversInQualityUpdate /t REG_DWORD /d 0 /f");
    }


    internal static async void DisableWindowsInk()
    {
        await OptimizationOptions.StartInCmd("reg add HKLM\\SOFTWARE\\Policies\\Microsoft\\WindowsInkWorkspace /v AllowWindowsInkWorkspace /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add HKLM\\SOFTWARE\\Policies\\Microsoft\\WindowsInkWorkspace /v AllowSuggestedAppsInWindowsInkWorkspace /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add HKCU\\SOFTWARE\\Microsoft\\TabletTip\\1.7 /v EnableInkingWithTouch /t REG_DWORD /d 0 /f");
    }

    internal static async void EnableWindowsInk()
    {
        await OptimizationOptions.StartInCmd("reg add HKLM\\SOFTWARE\\Policies\\Microsoft\\WindowsInkWorkspace /v AllowWindowsInkWorkspace /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add HKLM\\SOFTWARE\\Policies\\Microsoft\\WindowsInkWorkspace /v AllowSuggestedAppsInWindowsInkWorkspace /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add HKCU\\SOFTWARE\\Microsoft\\TabletTip\\1.7 /v EnableInkingWithTouch /t REG_DWORD /d 1 /f");
    }


    internal static async void DisableSpellingAndTypingFeatures()
    {
        await OptimizationOptions.StartInCmd("reg add HKCU\\SOFTWARE\\Microsoft\\TabletTip\\1.7 /v EnableAutocorrection /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add HKCU\\SOFTWARE\\Microsoft\\TabletTip\\1.7 /v EnableSpellchecking /t REG_DWORD /d 0 /f");

        await OptimizationOptions.StartInCmd("reg add HKCU\\Software\\Microsoft\\Input\\Settings /v InsightsEnabled /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add HKCU\\SOFTWARE\\Microsoft\\TabletTip\\1.7 /v EnableDoubleTapSpace /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add HKCU\\SOFTWARE\\Microsoft\\TabletTip\\1.7 /v EnablePredictionSpaceInsertion /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add HKCU\\SOFTWARE\\Microsoft\\TabletTip\\1.7 /v EnableTextPrediction /t REG_DWORD /d 0 /f");
    }

    internal static async void EnableSpellingAndTypingFeatures()
    {
        await OptimizationOptions.StartInCmd("reg add HKCU\\SOFTWARE\\Microsoft\\TabletTip\\1.7 /v EnableAutocorrection /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add HKCU\\SOFTWARE\\Microsoft\\TabletTip\\1.7 /v EnableSpellchecking /t REG_DWORD /d 1 /f");

        await OptimizationOptions.StartInCmd("reg add HKCU\\Software\\Microsoft\\Input\\Settings /v InsightsEnabled /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add HKCU\\SOFTWARE\\Microsoft\\TabletTip\\1.7 /v EnableDoubleTapSpace /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add HKCU\\SOFTWARE\\Microsoft\\TabletTip\\1.7 /v EnablePredictionSpaceInsertion /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add HKCU\\SOFTWARE\\Microsoft\\TabletTip\\1.7 /v EnableTextPrediction /t REG_DWORD /d 1 /f");
    }


    internal static void EnableFaxService()
    {
        Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Fax", "Start", "3", RegistryValueKind.DWord);
    }

    internal static void DisableFaxService()
    {
        OptimizationOptions.StopService("Fax");
        Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Fax", "Start", "4", RegistryValueKind.DWord);
    }

    internal static async void EnableInsiderService()
    {
        Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\wisvc", "Start", "3", RegistryValueKind.DWord);
        await OptimizationOptions.StartInCmd("sc start wisvc");
    }

    internal static void DisableInsiderService()
    {
        OptimizationOptions.StopService("wisvc");
        Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\wisvc", "Start", "4", RegistryValueKind.DWord);
    }


    internal static async void DisableSmartScreen()
    {
        await OptimizationOptions.StartInCmd("reg add HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Attachments /v SaveZoneInformation /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Attachments /v ScanWithAntiVirus /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\System /v ShellSmartScreenLevel /t REG_SZ /d Warn /f");
        await OptimizationOptions.StartInCmd("reg add HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\System /v EnableSmartScreen /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer /v SmartScreenEnabled /t REG_SZ /d Off /f");
        await OptimizationOptions.StartInCmd("reg add HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Internet Explorer\\PhishingFilter /v EnabledV9 /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\AppHost /v PreventOverride /t REG_DWORD /d 0 /f");

        await OptimizationOptions.StartInCmd("reg add HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Notifications\\Settings\\Windows.SystemToast.SecurityAndMaintenance /v Enabled /t REG_DWORD /d 0 /f");
    }

    internal static async void EnableSmartScreen()
    {
        await OptimizationOptions.StartInCmd("reg add HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Attachments /v SaveZoneInformation /t REG_DWORD /d 2 /f");
        await OptimizationOptions.StartInCmd("reg add HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Attachments /v ScanWithAntiVirus /t REG_DWORD /d 2 /f");
        await OptimizationOptions.StartInCmd("reg add HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\System /v EnableSmartScreen /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer /v SmartScreenEnabled /t REG_SZ /d On /f");
        await OptimizationOptions.StartInCmd("reg add HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Internet Explorer\\PhishingFilter /v EnabledV9 /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg delete HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\AppHost /v PreventOverride /f");

    }

    internal static void DisableCloudClipboard()
    {
        Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\System", "AllowClipboardHistory", "0", RegistryValueKind.DWord);
        Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\System", "AllowCrossDeviceClipboard", "0", RegistryValueKind.DWord);
        Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Clipboard", "EnableClipboardHistory", "0", RegistryValueKind.DWord);
        Registry.SetValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Clipboard", "EnableClipboardHistory", "0", RegistryValueKind.DWord);
    }

    internal static async void EnableCloudClipboard()
    {
        await OptimizationOptions.StartInCmd("reg delete HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\System /v AllowClipboardHistory /f");
        await OptimizationOptions.StartInCmd("reg delete HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\System /v AllowCrossDeviceClipboard /f");
        await OptimizationOptions.StartInCmd("reg delete HKEY_CURRENT_USER\\Software\\Microsoft\\Clipboard /v EnableClipboardHistory /f");
        await OptimizationOptions.StartInCmd("reg delete HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Clipboard /v EnableClipboardHistory /f");
    }

    internal static async void DisableStickyKeys()
    {
        await OptimizationOptions.StartInCmd("reg add HKEY_CURRENT_USER\\Control Panel\\Accessibility\\StickyKeys /v Flags /t REG_SZ /d 506 /f");
        await OptimizationOptions.StartInCmd("reg add HKEY_CURRENT_USER\\Control Panel\\Accessibility\\Keyboard Response /v Flags /t REG_SZ /d 122 /f");
        await OptimizationOptions.StartInCmd("reg add HKEY_CURRENT_USER\\Control Panel\\Accessibility\\ToggleKeys /v Flags /t REG_SZ /d 58 /f");
        await OptimizationOptions.StartInCmd("reg add HKEY_USERS\\.DEFAULT\\Control Panel\\Accessibility\\StickyKeys /v Flags /t REG_SZ /d 506 /f");
        await OptimizationOptions.StartInCmd("reg add HKEY_USERS\\.DEFAULT\\Control Panel\\Accessibility\\Keyboard Response /v Flags /t REG_SZ /d 122 /f");
        await OptimizationOptions.StartInCmd("reg add HKEY_USERS\\.DEFAULT\\Control Panel\\Accessibility\\ToggleKeys /v Flags /t REG_SZ /d 58 /f");
    }

    internal static async void EnableStickyKeys()
    {
        await OptimizationOptions.StartInCmd("reg add HKEY_CURRENT_USER\\Control Panel\\Accessibility\\StickyKeys /v Flags /t REG_SZ /d 510 /f");
        await OptimizationOptions.StartInCmd("reg add HKEY_CURRENT_USER\\Control Panel\\Accessibility\\Keyboard Response /v Flags /t REG_SZ /d 126 /f");
        await OptimizationOptions.StartInCmd("reg add HKEY_CURRENT_USER\\Control Panel\\Accessibility\\ToggleKeys /v Flags /t REG_SZ /d 62 /f");
        await OptimizationOptions.StartInCmd("reg add HKEY_USERS\\.DEFAULT\\Control Panel\\Accessibility\\StickyKeys /v Flags /t REG_SZ /d 510 /f");
        await OptimizationOptions.StartInCmd("reg add HKEY_USERS\\.DEFAULT\\Control Panel\\Accessibility\\Keyboard Response /v Flags /t REG_SZ /d 126 /f");
        await OptimizationOptions.StartInCmd("reg add HKEY_USERS\\.DEFAULT\\Control Panel\\Accessibility\\ToggleKeys /v Flags /t REG_SZ /d 62 /f");
    }

    internal static async void RemoveCastToDevice()
    {
        await OptimizationOptions.StartInCmd("REG ADD \"HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Shell Extensions\\Blocked\" /V {7AD84985-87B4-4a16-BE58-8B72A5B390F7} /T REG_SZ /D \"Play to Menu\" /F");
    }

    internal static async void AddCastToDevice()
    {
        await OptimizationOptions.StartInCmd("REG DELETE \"HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Shell Extensions\\Blocked\" /V {7AD84985-87B4-4a16-BE58-8B72A5B390F7} /F");
    }

    internal static async void DisableVBS()
    {
        await OptimizationOptions.StartInCmd("REG ADD \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\DeviceGuard\" /V EnableVirtualizationBasedSecurity /T REG_DWORD /D 0 /F");
    }

    internal static async void EnableVBS()
    {
        await OptimizationOptions.StartInCmd("REG DELETE \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\DeviceGuard\" /V EnableVirtualizationBasedSecurity /F");
    }

    internal static async void AlignTaskbarToLeft()
    {
        await OptimizationOptions.StartInCmd("reg add \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\" /v TaskbarAl /t REG_DWORD /d 0 /f");
    }

    internal static async void AlignTaskbarToCenter()
    {
        await OptimizationOptions.StartInCmd("reg add \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\" /v TaskbarAl /t REG_DWORD /d 1 /f");
    }

    internal static async void DisableSnapAssist()
    {
        await OptimizationOptions.StartInCmd("REG ADD \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\" /V EnableSnapAssistFlyout /T REG_DWORD /D 0 /F");
        await OptimizationOptions.StartInCmd("REG ADD \"HKEY_CURRENT_USER\\Control Panel\\Desktop\" /V DockMoving /T REG_SZ /D 0 /F");
    }

    internal static async void EnableSnapAssist()
    {
        await OptimizationOptions.StartInCmd("REG ADD \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\" /V EnableSnapAssistFlyout /T REG_DWORD /D 1 /F");
        await OptimizationOptions.StartInCmd("REG ADD \"HKEY_CURRENT_USER\\Control Panel\\Desktop\" /V DockMoving /T REG_SZ /D 1 /F");
    }

    internal static async void DisableWidgets()
    {
        await OptimizationOptions.StartInCmd("REG ADD \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\" /V TaskbarDa /T REG_DWORD /D 0 /F");
    }

    internal static async void EnableWidgets()
    {
        await OptimizationOptions.StartInCmd("REG Delete \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\" /V TaskbarDa /F");
    }

    internal static async void DisableChat()
    {
        await OptimizationOptions.StartInCmd("REG ADD \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\" /V TaskbarMn /T REG_DWORD /D 0 /F");
    }

    internal static async void EnableChat()
    {
        await OptimizationOptions.StartInCmd("REG Delete \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\" /V TaskbarMn /F");
    }

    internal static async void DisableShowMoreOptions()
    {
        await OptimizationOptions.StartInCmd("REG ADD \"HKEY_CURRENT_USER\\Software\\Classes\\CLSID\\{86ca1aa0-34aa-4e8b-a509-50c905bae2a2}\\InprocServer32\" /V \"\" /F");
    }

    internal static async void EnableShowMoreOptions()
    {
        await OptimizationOptions.StartInCmd("REG Delete \"HKEY_CURRENT_USER\\Software\\Classes\\CLSID\\{86ca1aa0-34aa-4e8b-a509-50c905bae2a2}\" /F");
    }

    internal static async void EnableFilesCompactMode()
    {
        await OptimizationOptions.StartInCmd("REG ADD \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\" /V UseCompactMode /T REG_DWORD /D 1 /F");
    }

    internal static async void DisableFilesCompactMode()
    {
        await OptimizationOptions.StartInCmd("REG ADD \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\" /V UseCompactMode /T REG_DWORD /D 0 /F");
    }

    internal static async void DisableStickers()
    {
        await OptimizationOptions.StartInCmd("REG Delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\PolicyManager\\current\\device\\Stickers\" /V EnableStickers /F");
    }

    internal static async void EnableStickers()
    {
        await OptimizationOptions.StartInCmd("REG ADD \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\PolicyManager\\current\\device\\Stickers\" /V EnableStickers /T REG_DWORD /D 1 /F");
    }


    internal static async void DisableEdgeDiscoverBar()
    {
        await OptimizationOptions.StartInCmd("REG ADD \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Edge\" /V HubsSidebarEnabled /T REG_DWORD /D 0 /F");
        await OptimizationOptions.StartInCmd("REG ADD \"HKEY_CURRENT_USER\\SOFTWARE\\Policies\\Microsoft\\Edge\" /V HubsSidebarEnabled /T REG_DWORD /D 0 /F");
        await OptimizationOptions.StartInCmd("REG ADD \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Edge\" /V WebWidgetAllowed /T REG_DWORD /D 0 /F");
    }

    internal static async void EnableEdgeDiscoverBar()
    {
        await OptimizationOptions.StartInCmd("REG Delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Edge\" /V HubsSidebarEnabled /F");
        await OptimizationOptions.StartInCmd("REG Delete \"HKEY_CURRENT_USER\\SOFTWARE\\Policies\\Microsoft\\Edge\" /V HubsSidebarEnabled /F");
        await OptimizationOptions.StartInCmd("REG Delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Edge\" /V WebWidgetAllowed /F");
    }

    internal static async void DisableEdgeTelemetry()
    {
        await OptimizationOptions.StartInCmd("REG ADD \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Edge\" /V PersonalizationReportingEnabled /T REG_DWORD /D 0 /F");
        await OptimizationOptions.StartInCmd("REG ADD \"HKEY_CURRENT_USER\\SOFTWARE\\Policies\\Microsoft\\Edge\" /V PersonalizationReportingEnabled /T REG_DWORD /D 0 /F");
        await OptimizationOptions.StartInCmd("REG ADD \"HKEY_CURRENT_USER\\SOFTWARE\\Policies\\Microsoft\\Edge\" /V UserFeedbackAllowed /T REG_DWORD /D 0 /F");
        await OptimizationOptions.StartInCmd("REG ADD \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Edge\" /V UserFeedbackAllowed /T REG_DWORD /D 0 /F");
        await OptimizationOptions.StartInCmd("REG ADD \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Edge\" /V MetricsReportingEnabled /T REG_DWORD /D 0 /F");
        await OptimizationOptions.StartInCmd("REG ADD \"HKEY_CURRENT_USER\\SOFTWARE\\Policies\\Microsoft\\Edge\" /V MetricsReportingEnabled /T REG_DWORD /D 0 /F");
        await OptimizationOptions.StartInCmd("REG ADD \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\MicrosoftEdge\\BooksLibrary\" /V EnableExtendedBooksTelemetry /T REG_DWORD /D 0 /F");
        await OptimizationOptions.StartInCmd("REG ADD \"HKEY_CURRENT_USER\\SOFTWARE\\Policies\\Microsoft\\MicrosoftEdge\\BooksLibrary\" /V EnableExtendedBooksTelemetry /T REG_DWORD /D 0 /F");
        await OptimizationOptions.StartInCmd("REG ADD \"HKEY_CURRENT_USER\\Software\\Microsoft\\Edge\\SmartScreenEnabled\" /V \"\" /T REG_DWORD /D 0 /F");
        await OptimizationOptions.StartInCmd("REG ADD \"HKEY_CURRENT_USER\\Software\\Microsoft\\Edge\\SmartScreenPuaEnabled\" /V \"\" /T REG_DWORD /D 0 /F");
        await OptimizationOptions.StartInCmd("REG ADD \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Edge\" /V SpotlightExperiencesAndRecommendationsEnabled /T REG_DWORD /D 0 /F");
        await OptimizationOptions.StartInCmd("REG ADD \"HKEY_CURRENT_USER\\SOFTWARE\\Policies\\Microsoft\\Edge\" /V SpotlightExperiencesAndRecommendationsEnabled /T REG_DWORD /D 0 /F");
    }

    internal static async void EnableEdgeTelemetry()
    {
        await OptimizationOptions.StartInCmd("REG Delete \"HKEY_CURRENT_USER\\Software\\Microsoft\\Edge\\SmartScreenEnabled\" /V \"\" /F");
        await OptimizationOptions.StartInCmd("REG Delete \"HKEY_CURRENT_USER\\Software\\Microsoft\\Edge\\SmartScreenPuaEnabled\" /V \"\" /F");
        await OptimizationOptions.StartInCmd("REG Delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Edge\" /V MetricsReportingEnabled /F");
        await OptimizationOptions.StartInCmd("REG Delete \"HKEY_CURRENT_USER\\SOFTWARE\\Policies\\Microsoft\\Edge\" /V MetricsReportingEnabled /F");
        await OptimizationOptions.StartInCmd("REG Delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\MicrosoftEdge\\BooksLibrary\" /V EnableExtendedBooksTelemetry /F");
        await OptimizationOptions.StartInCmd("REG Delete \"HKEY_CURRENT_USER\\SOFTWARE\\Policies\\Microsoft\\MicrosoftEdge\\BooksLibrary\" /V EnableExtendedBooksTelemetry /F");
        await OptimizationOptions.StartInCmd("REG Delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Edge\" /V PersonalizationReportingEnabled /F");
        await OptimizationOptions.StartInCmd("REG Delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Edge\" /V UserFeedbackAllowed /F");
        await OptimizationOptions.StartInCmd("REG Delete \"HKEY_CURRENT_USER\\SOFTWARE\\Policies\\Microsoft\\Edge\" /V PersonalizationReportingEnabled /F");
        await OptimizationOptions.StartInCmd("REG Delete \"HKEY_CURRENT_USER\\SOFTWARE\\Policies\\Microsoft\\Edge\" /V UserFeedbackAllowed /F");
        await OptimizationOptions.StartInCmd("REG Delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Edge\" /V SpotlightExperiencesAndRecommendationsEnabled /F");
        await OptimizationOptions.StartInCmd("REG Delete \"HKEY_CURRENT_USER\\SOFTWARE\\Policies\\Microsoft\\Edge\" /V SpotlightExperiencesAndRecommendationsEnabled /F");
    }


    internal static async void DisableCoPilotAI()
    {
        await OptimizationOptions.StartInCmd("REG ADD \"HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\Windows\\WindowsCopilot\" /V TurnOffWindowsCopilot /T REG_DWORD /D 1 /F");
    }

    internal static async void EnableCoPilotAI()
    {
        await OptimizationOptions.StartInCmd("REG Delete \"HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\Windows\\WindowsCopilot\" /V TurnOffWindowsCopilot /F");
    }


    internal static async void DisableVisualStudioTelemetry()
    {
        await OptimizationOptions.StartInCmd("REG ADD \"HKEY_CURRENT_USER\\Software\\Microsoft\\VisualStudio\\Telemetry\" /V TurnOffSwitch /T REG_DWORD /D 1 /F");
        await OptimizationOptions.StartInCmd("REG ADD \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\VisualStudio\\Feedback\" /V DisableFeedbackDialog /T REG_DWORD /D 1 /F");
        await OptimizationOptions.StartInCmd("REG ADD \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\VisualStudio\\Feedback\" /V DisableEmailInput /T REG_DWORD /D 1 /F");
        await OptimizationOptions.StartInCmd("REG ADD \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\VisualStudio\\Feedback\" /V DisableScreenshotCapture /T REG_DWORD /D 1 /F");
        await OptimizationOptions.StartInCmd("REG ADD \"HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\VisualStudio\\SQM\" /V OptIn /T REG_DWORD /D 0 /F");
        await OptimizationOptions.StartInCmd("REG ADD \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\VisualStudio\\Setup\" /V ConcurrentDownloads /T REG_DWORD /D 2 /F");

        if (Environment.Is64BitOperatingSystem)
        {
            await OptimizationOptions.StartInCmd("REG ADD \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\VSCommon\\14.0\\SQM\" /V OptIn /T REG_DWORD /D 0 /F");
            await OptimizationOptions.StartInCmd("REG ADD \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\VSCommon\\15.0\\SQM\" /V OptIn /T REG_DWORD /D 0 /F");
            await OptimizationOptions.StartInCmd("REG ADD \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\VSCommon\\16.0\\SQM\" /V OptIn /T REG_DWORD /D 0 /F");
        }
        else
        {
            await OptimizationOptions.StartInCmd("REG ADD \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Microsoft\\VSCommon\\14.0\\SQM\" /V OptIn /T REG_DWORD /D 0 /F");
            await OptimizationOptions.StartInCmd("REG ADD \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Microsoft\\VSCommon\\15.0\\SQM\" /V OptIn /T REG_DWORD /D 0 /F");
            await OptimizationOptions.StartInCmd("REG ADD \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Microsoft\\VSCommon\\16.0\\SQM\" /V OptIn /T REG_DWORD /D 0 /F");
        }
        await OptimizationOptions.StartInCmd("SC Config VSStandardCollectorService150 Start= disabled");
    }

    internal static async void EnableVisualStudioTelemetry()
    {
        await OptimizationOptions.StartInCmd("REG Delete \"HKEY_CURRENT_USER\\Software\\Microsoft\\VisualStudio\\Telemetry\" /V TurnOffSwitch /F");
        await OptimizationOptions.StartInCmd("REG Delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\VisualStudio\\Feedback\" /V DisableFeedbackDialog /F");
        await OptimizationOptions.StartInCmd("REG Delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\VisualStudio\\Feedback\" /V DisableEmailInput /F");
        await OptimizationOptions.StartInCmd("REG Delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\VisualStudio\\Feedback\" /V DisableScreenshotCapture /F");
        await OptimizationOptions.StartInCmd("REG Delete \"HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\VisualStudio\\SQM\" /V OptIn /F");
        await OptimizationOptions.StartInCmd("REG Delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\VisualStudio\\Setup\" /V ConcurrentDownloads /F");

        if (Environment.Is64BitOperatingSystem)
        {
            await OptimizationOptions.StartInCmd("REG Delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\VSCommon\\14.0\\SQM\" /V OptIn /F");
            await OptimizationOptions.StartInCmd("REG Delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\VSCommon\\15.0\\SQM\" /V OptIn /F");
            await OptimizationOptions.StartInCmd("REG Delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\VSCommon\\16.0\\SQM\" /V OptIn /F");
        }
        else
        {
            await OptimizationOptions.StartInCmd("REG Delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Microsoft\\VSCommon\\14.0\\SQM\" /V OptIn /F");
            await OptimizationOptions.StartInCmd("REG Delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Microsoft\\VSCommon\\15.0\\SQM\" /V OptIn /F");
            await OptimizationOptions.StartInCmd("REG Delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Microsoft\\VSCommon\\16.0\\SQM\" /V OptIn /F");
        }
        await OptimizationOptions.StartInCmd("SC Config VSStandardCollectorService150 Start= demand");
    }

    internal static async void DisableNvidiaTelemetry()
    {
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\NvTelemetryContainer\" /v Start /t REG_DWORD /d 4 /f");

        await OptimizationOptions.StartInCmd("schtasks.exe /change /tn NvTmRepOnLogon_{B2FE1952-0186-46C3-BAEC-A80AA35AC5B8} /disable");
        await OptimizationOptions.StartInCmd("schtasks.exe /change /tn NvTmRep_{B2FE1952-0186-46C3-BAEC-A80AA35AC5B8} /disable");
        await OptimizationOptions.StartInCmd("schtasks.exe /change /tn NvTmMon_{B2FE1952-0186-46C3-BAEC-A80AA35AC5B8} /disable");
        await OptimizationOptions.StartInCmd("net.exe stop NvTelemetryContainer");
        await OptimizationOptions.StartInCmd("sc.exe config NvTelemetryContainer start= disabled");
        await OptimizationOptions.StartInCmd("sc.exe stop NvTelemetryContainer");
    }

    internal static async void EnableNvidiaTelemetry()
    {
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\NvTelemetryContainer\" /v Start /t REG_DWORD /d 2 /f");

        await OptimizationOptions.StartInCmd("schtasks.exe /change /tn NvTmRepOnLogon_{B2FE1952-0186-46C3-BAEC-A80AA35AC5B8} /enable");
        await OptimizationOptions.StartInCmd("schtasks.exe /change /tn NvTmRep_{B2FE1952-0186-46C3-BAEC-A80AA35AC5B8} /enable");
        await OptimizationOptions.StartInCmd("schtasks.exe /change /tn NvTmMon_{B2FE1952-0186-46C3-BAEC-A80AA35AC5B8} /enable");
        await OptimizationOptions.StartInCmd("net.exe start NvTelemetryContainer");
        await OptimizationOptions.StartInCmd("sc.exe config NvTelemetryContainer start= enabled");
        await OptimizationOptions.StartInCmd("sc.exe start NvTelemetryContainer");
    }

    internal static async void DisableChromeTelemetry()
    {

        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Google\\Chrome\" /v MetricsReportingEnabled /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Google\\Chrome\" /v ChromeCleanupReportingEnabled /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Google\\Chrome\" /v ChromeCleanupEnabled /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Google\\Chrome\" /v UserFeedbackAllowed /t REG_DWORD /d 0 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Google\\Chrome\" /v DeviceMetricsReportingEnabled /t REG_DWORD /d 0 /f");
    }

    internal static async void EnableChromeTelemetry()
    {
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Google\\Chrome\" /v MetricsReportingEnabled /f");
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Google\\Chrome\" /v ChromeCleanupReportingEnabled /f");
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Google\\Chrome\" /v ChromeCleanupEnabled /f");
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Google\\Chrome\" /v UserFeedbackAllowed /f");
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Google\\Chrome\" /v DeviceMetricsReportingEnabled /f");

    }

    internal static async void DisableFirefoxTelemetry()
    {
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Mozilla\\Firefox\" /v DisableTelemetry /t REG_DWORD /d 1 /f");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Mozilla\\Firefox\" /v DisableDefaultBrowserAgent /t REG_DWORD /d 1 /f");

        await OptimizationOptions.StartInCmd("schtasks.exe /change /disable /tn \"\\Mozilla\\Firefox Default Browser Agent 308046B0AF4A39CB\"");
        await OptimizationOptions.StartInCmd("schtasks.exe /change /disable /tn \"\\Mozilla\\Firefox Default Browser Agent D2CEEC440E2074BD\"");
    }

    internal static async void EnableFirefoxTelemetry()
    {
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Mozilla\\Firefox\" /v DisableTelemetry /f");
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Mozilla\\Firefox\" /v DisableDefaultBrowserAgent /f");

        await OptimizationOptions.StartInCmd("schtasks.exe /change /enable /tn \"\\Mozilla\\Firefox Default Browser Agent 308046B0AF4A39CB\"");
        await OptimizationOptions.StartInCmd("schtasks.exe /change /enable /tn \"\\Mozilla\\Firefox Default Browser Agent D2CEEC440E2074BD\"");
    }
    internal static async void DisableHibernation()
    {
        await OptimizationOptions.StartInCmd("powercfg -h off");
        await OptimizationOptions.StartInCmd("powercfg -h off");
        await OptimizationOptions.StartInCmd("reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Power\" /v HibernateEnabled /t REG_DWORD /d 0 /f");
    }

    internal static async void EnableHibernation()
    {
        await OptimizationOptions.StartInCmd("powercfg -h on");
        await OptimizationOptions.StartInCmd("reg delete \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Power\" /v HibernateEnabled /f");
        await OptimizationOptions.StartInCmd("powercfg -h on");
    }

    internal static async void EnableEndTask()
    {
        await OptimizationOptions.StartInCmd("reg add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\\TaskbarDeveloperSettings /v TaskbarEndTask /t REG_DWORD /d 1 /f");
    }

    internal static async void DisableEndTask()
    {
        await OptimizationOptions.StartInCmd("reg add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced\\TaskbarDeveloperSettings /v TaskbarEndTask /t REG_DWORD /d 0 /f");
    }

    public static async Task<bool> RemoveTempFiles()
    {
        // Stop Explorer
        await Task.Run(() => OptimizationOptions.StartInCmd("taskkill /F /IM explorer.exe"));

        try
        {

            // List of commands to remove temporary files
            var tempCommands = new[]
            {
            "del /F /S /Q %windir%\\Temp\\*",
            "del /F /S /Q %windir%\\SoftwareDistribution\\Download\\*",
            "del /F /S /Q %windir%\\SoftwareDistribution\\DeliveryOptimization\\*",
            "del /F /S /Q %windir%\\Prefetch\\*",
            "del /F /S /Q %windir%\\Logs\\CBS\\*",
            "del /F /S /Q %windir%\\Temp\\WindowsUpdate.log",
            "del /F /S /Q %windir%\\MEMORY.DMP",
            "del /F /S /Q %windir%\\Minidump\\*.dmp",
            "del /F /S /Q %windir%\\Setup\\Temp\\*",
            "del /F /S /Q %windir%\\Downloaded Program Files\\*",
            "del /F /S /Q %programdata%\\Microsoft\\Windows\\WER\\ReportQueue\\*",
            "del /F /S /Q %localappdata%\\Temp\\*",
            "del /F /S /Q %localappdata%\\Microsoft\\Windows\\WER\\ReportArchive\\*",
            "del /F /S /Q %localappdata%\\Microsoft\\Windows\\INetCache\\*",
            "del /F /S /Q %systemdrive%\\*.tmp",
            "del /F /S /Q %systemdrive%\\*._mp",
            "del /F /S /Q %systemdrive%\\*.log",
            "del /F /S /Q %systemdrive%\\*.gid",
            "del /F /S /Q %systemdrive%\\*.chk",
            "del /F /S /Q %systemdrive%\\*.old",
            "del /F /S /Q %systemdrive%\\found.*",
            "del /F /S /Q %userprofile%\\cookies\\*.*",
            "del /F /S /Q %userprofile%\\recent\\*.*",
            "del /F /S /Q \"%userprofile%\\Local Settings\\Temporary Internet Files\\*.*\"",
            "del /F /S /Q \"%userprofile%\\Local Settings\\Temp\\*.*\"",
            "del /F /S /Q \"%userprofile%\\recent\\*.*\"",
            "del /A /Q \"%localappdata%\\Microsoft\\Windows\\Explorer\\iconcache*\"",
            "del /A /Q \"%localappdata%\\Microsoft\\Windows\\Explorer\\thumbcache*\"",
            "del /F /S /Q /A %localappdata%\\Microsoft\\Windows\\Explorer\\thumbcache_*.db",
            "rd /S /Q \"%TEMP%\"",
            "PowerShell.exe -NoProfile -Command \"Clear-RecycleBin -Force\"",
            "PowerShell.exe -NoProfile -Command \"wevtutil cl System\"",
            "PowerShell.exe -NoProfile -Command \"wevtutil cl Application\"",
            "PowerShell.exe -NoProfile -Command \"Remove-Item -Path 'C:\\Users\\%USERNAME%\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\Cache\\*' -Recurse -Force\"",
            "PowerShell.exe -NoProfile -Command \"Remove-Item -Path 'C:\\Users\\%USERNAME%\\AppData\\Local\\Microsoft\\Edge\\User Data\\Default\\Cache\\*' -Recurse -Force\"",
            "PowerShell.exe -NoProfile -Command \"Remove-Item -Path 'C:\\Users\\%USERNAME%\\AppData\\Local\\Mozilla\\Firefox\\Profiles\\*\\cache2\\*' -Recurse -Force\"",
            "ipconfig /flushdns",
            };

            // Execute all commands
            var tempTasks = tempCommands.AsParallel().Select(cmd => OptimizationOptions.StartInCmd(cmd));
            await Task.WhenAll(tempTasks);

            // Start explorer
            await Task.Run(() => OptimizationOptions.StartInCmd("start explorer.exe"));

            return true;
        }
        catch
        {
            return false;
        }
    }
}