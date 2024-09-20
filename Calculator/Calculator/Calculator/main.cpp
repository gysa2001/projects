#include "Calculator.h"
#include <windows.h>
using namespace System;
using namespace System::Windows::Forms;
[STAThreadAttribute]

int WINAPI wWinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, PWSTR pCmdLine, int nCmdShow){
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false);
	Calculator::Calculator form;
	Application::Run(% form);
	return 0;
}
