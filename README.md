# Destiny 2 matchmaking disable
A script that allows you to disable matchmaking in Destiny 2, all this script does is adds firewall rules when first ran and if rules are already in place (second run) it will disable them and re enable match making. 

## Why use this? 

So you can do bounties etc alone and not with pesky people :) 

## Before you use this please read

Make sure to only use this when on Destiny 2, run the script to disable firewall rules before shutting down steam as you wont be able to launch steam online. I suggest this is used in Orbit to prevent crashing. 

## How do i use this?

Before trying to run the script you must allow Windows Powershell to run .ps1 files, this can be done by oppening Powershell as admin and typing the following. [(Download here)](https://github.com/MrPleasant-exe/Destiny-2-Solo-lobby/releases).

> set-executionpolicy remotesigned

> Set-ExecutionPolicy -Scope Process -ExecutionPolicy Bypass (might be needed)

Once promoted type "a" and hit enter. 

![howto](http://mrpl.me/pc1046b_rfx3.gif)

Once you have done that, right click the script > open with > windows powershell, don't worry if its blank, sometimes text wont load, if this is the case press any key. (if it closes this is also ok)

Recent report suggest this is no longer working properly with powershell, till i figure out what the cause is i suggest running it using Windows Powershell ISE which can be located:

> "C:\Windows\system32\WindowsPowerShell\v1.0\powershell_ise.exe"

When disabling: http://mrpl.me/P31047b_rfs8.png

When enabling: http://mrpl.me/l21048b_rff8.png

Download: https://github.com/MrPleasant-exe/Destiny-2-Solo-lobby/releases

Special thanks to various Reddit users for the specific ports etc
