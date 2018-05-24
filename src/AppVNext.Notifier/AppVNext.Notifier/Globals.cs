﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Environment;

namespace AppVNext.Notifier
{
	class Globals
	{
		//General
		internal static readonly string NewLine = Environment.NewLine;
		internal static readonly string DefaultApplicationId = "com.brave.notifier";
		internal static readonly string DefaultApplicationName = "brave-windows-notifier";

		//Arguments help text
		internal static readonly string HelpForRegister =
			$"Argument -r requires 2 values: <appId string> and <appName string>.{NewLine}" +
			$"Example: -r \"com.brave.windows-notifier\" \"brave-windows-notifier\"{NewLine}";

		internal static readonly string HelpForTitle =
			$"Argument -t requires 1 value: <title string>.{NewLine}" +
			$"Example: -t \"Notification Title\"{NewLine}";

		internal static readonly string HelpForMessage =
			$"Argument -m requires 1 value: <message string>.{NewLine}" +
			$"Example: -m \"Notification message.\"{NewLine}";

		internal static readonly string HelpForPicture =
			$"Argument -p requires 1 value: <image URI>.{NewLine}" +
			$"Example: -p \"C:\\Pictures\\Picture.png\"{NewLine}";

		internal static readonly string HelpForId =
			$"Argument -id requires 1 value: <id string>.{NewLine}" +
			$"Example: -id \"12345\"{NewLine}";

		internal static readonly string HelpForSound =
			$"Argument -s requires 1 value: <title string>.{NewLine}" +
			$"Example: -s \"C:\\Sounds\\Sound.wav\"{NewLine}";

		internal static readonly string HelpForAppId =
			$"Argument -appID requires 1 value: <appID string>.{NewLine}" +
			$"Example: -appID \"com.brave.windows-notifier\"{NewLine}";

		internal static readonly string HelpForClose =
			$"Argument -close requires 1 value: <ID string>.{NewLine}" +
			$"Example: -close \"12345\"{NewLine}";

		internal static readonly string HelpForDuration =
			$"Argument -d requires 1 value: <short|long>.{NewLine}" +
			$"Example: -d \"long\"{NewLine}";

		internal static readonly string HelpForInvalidArgument =
			$"Argument '{{0}}' is invalid.{NewLine}";

		internal static readonly string HelpForNullMessage =
			$"At least argument -m <message string> is required.{NewLine}" +
			$"Example: -m \"Notification message.\"{NewLine}";

		internal static readonly string HelpForErrors = 
			$"{NewLine}Please type 'notifier help' to show the valid arguments.{NewLine}";

		internal static readonly string HelpForRegisterSuccess =
			$"The application shortcut for '{{0}}' '{{1}}' was successfully created.{NewLine}";

		internal static readonly string HelpForRegisterFail =
			$"The application shortcut for '{{0}}' '{{1}}' already existed.{NewLine}";

		//Help text
		internal static readonly string HelpText =
			$"Create a send notifications.{NewLine}{NewLine}" +
			$"Usage: notifier <command>{NewLine}{NewLine}" +
			$"Commands:{NewLine}{NewLine}" +
			$"[-r] <appId string><appName string>	Registers notifier into the Windows machine.{NewLine}" +
			$"[-t] <title string>			Title is displayed on the first line of the notification.{NewLine}" +
			$"[-m] <message string>			Message is displayed wrappped below the title of the notification.{NewLine}" +
			$"[-p] <image URI>			URI for a picture file to be displayed with the notification. Local files only. {NewLine}" +
			$"[-w]					Wait for notification to expire or activate.{NewLine}" +
			$"[-id] <id string>			Sets the ID of the toast notification to be able to close it.{NewLine}" +
			$"[s] [<sound URI>][<Windows sound>]	URI for a sound file or Windows sound to play when the notification displays.{NewLine}" +
			$"					For possible Windows sound values visit http://msdn.microsoft.com/en-us/library/windows/apps/hh761492.aspx.{NewLine}" +
			$"[-silent]				Does not play a sound when showing the notification.{NewLine}" +
			$"[-d] <short|long>				Determines how long to display the notification for. Default is 'short'.{NewLine}" +
			$"[-appID] <appID string>			Used to display the notification.{NewLine}" +
			$"[-close] <ID string>			Closes notification. In order to be able to close a notification,{NewLine}" +
			$"					the parameter -w must be used to create the notification.{NewLine}" +
			$"[-?]					Displays this help.{NewLine}" +
			$"[-help]					Displays this help.{NewLine}{NewLine}" +
			$"Examples:{NewLine}{NewLine}" +
			$"notifier \"Hello World!\"{NewLine}" +
			$"notifier -t \"Notification Title\" -m \"Notification messsage.\"{NewLine}" +
			$"notifier help{NewLine}" +
			$"notifier ?{NewLine}" +
			$"notifier register com.brave.windows-notifier brave-windows-notifier{NewLine}" +
			$"{NewLine}";
	}
}
