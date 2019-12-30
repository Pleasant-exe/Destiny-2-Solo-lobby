    if (-Not ([Security.Principal.WindowsPrincipal] [Security.Principal.WindowsIdentity]::GetCurrent()).IsInRole([Security.Principal.WindowsBuiltInRole] 'Administrator')) {
    if ([int](Get-CimInstance -Class Win32_OperatingSystem | Select-Object -ExpandProperty BuildNumber) -ge 6000) {
        $CommandLine = "-File `"" + $MyInvocation.MyCommand.Path + "`" " + $MyInvocation.UnboundArguments
        Start-Process -FilePath PowerShell.exe -Verb Runas -ArgumentList $CommandLine
        Exit
    }
}

$rule = Get-NetFirewallRule -DisplayName "Destiny2-Solo-1" 2> $null;
if ($rule) {
    Remove-NetFirewallRule -DisplayName "Destiny2-Solo-1";
} else {
    New-NetFirewallRule -DisplayName "Destiny2-Solo-1" -Direction Outbound -LocalPort 1935,3097,3478-3480 -Protocol TCP -Action Block;
}
$rule = Get-NetFirewallRule -DisplayName "Destiny2-Solo-2" 2> $null;
if ($rule) {
    Remove-NetFirewallRule -DisplayName "Destiny2-Solo-2";
} else {
    New-NetFirewallRule -DisplayName "Destiny2-Solo-2" -Direction Outbound -LocalPort 1935,3097,3478-3480 -Protocol UDP -Action Block;
}
$rule = Get-NetFirewallRule -DisplayName "Destiny2-Solo-3" 2> $null;
if ($rule) {
    Remove-NetFirewallRule -DisplayName "Destiny2-Solo-3";
} else {
    New-NetFirewallRule -DisplayName "Destiny2-Solo-3" -Direction Inbound -LocalPort 1935,3097,3478-3480 -Protocol TCP -Action Block;
}
$rule = Get-NetFirewallRule -DisplayName "Destiny2-Solo-4" 2> $null;
if ($rule) {
    Remove-NetFirewallRule -DisplayName "Destiny2-Solo-4";
} else {
    New-NetFirewallRule -DisplayName "Destiny2-Solo-4" -Direction Inbound -LocalPort 1935,3097,3478-3480 -Protocol UDP -Action Block;
}

Write-Host "Successful"
Write-Host "Press any key to exit"
$null = $Host.UI.RawUI.ReadKey('NoEcho,IncludeKeyDown');