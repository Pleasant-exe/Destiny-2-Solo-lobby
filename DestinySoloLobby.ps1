if (-Not ([Security.Principal.WindowsPrincipal] [Security.Principal.WindowsIdentity]::GetCurrent()).IsInRole([Security.Principal.WindowsBuiltInRole] 'Administrator')) {
    if ([int](Get-CimInstance -Class Win32_OperatingSystem | Select-Object -ExpandProperty BuildNumber) -ge 6000) {
        $CommandLine = "-File `"" + $MyInvocation.MyCommand.Path + "`" " + $MyInvocation.UnboundArguments
        Start-Process -FilePath PowerShell.exe -Verb Runas -ArgumentList $CommandLine
        Exit
    }
}

$soloLobbyEnabled = Get-NetFirewallRule -DisplayName "Destiny2-TCP-Out" 2> $null

if ($soloLobbyEnabled) {
    $msg = "Solo Lobby Disabled!"
    Remove-NetFirewallRule -DisplayName "Destiny2-TCP-Out";
    Remove-NetFirewallRule -DisplayName "Destiny2-UDP-Out";
    Remove-NetFirewallRule -DisplayName "Destiny2-TCP-In";
    Remove-NetFirewallRule -DisplayName "Destiny2-UDP-In";
} else {
    $msg = "Solo Lobby Enabled!"
    New-NetFirewallRule -DisplayName "Destiny2-TCP-Out" -Direction Outbound -RemotePort 27000-27200,3097 -Protocol TCP -Action Block;
    New-NetFirewallRule -DisplayName "Destiny2-UDP-Out" -Direction Outbound -RemotePort 27000-27200,3097 -Protocol UDP -Action Block;
    New-NetFirewallRule -DisplayName "Destiny2-TCP-In"  -Direction Inbound  -RemotePort 27000-27200,3097 -Protocol TCP -Action Block;
    New-NetFirewallRule -DisplayName "Destiny2-UDP-In"  -Direction Inbound  -RemotePort 27000-27200,3097 -Protocol UDP -Action Block;
}

Write-Host $msg
Write-Host "Press any key to exit"
$null = $Host.UI.RawUI.ReadKey('NoEcho,IncludeKeyDown');
