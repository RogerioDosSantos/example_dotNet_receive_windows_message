// cpp_application.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <Windows.h>

int main(int argc, char* argv[])
{
	const int message_for_action = WM_USER + 1;
	HWND dot_net_application_window = FindWindow(NULL, _T("dotNetApplicationWindowTitle"));
	
	printf("Sending Message (Synchronous)\n");
	SendMessage(dot_net_application_window, message_for_action, 0, NULL);
	printf("Sending Message Sent and Processed\n");

	printf("Posting Message (Asynchronous)\n");
	PostMessage(dot_net_application_window, message_for_action, 0, NULL);
	printf("Posting Message Sent\n");
	
	system("pause");
	return 0;
}
