#pragma once
#include "LogicPart.h"
#include <msclr\marshal_cppstd.h>
#include <iostream>
namespace Calculator {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;
	using namespace System::Runtime::InteropServices;

	/// <summary>
	/// Summary for Calculator
	/// </summary>
	public ref class Calculator : public System::Windows::Forms::Form
	{
	public:
		Calculator(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~Calculator()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::TextBox^ input;
	protected:

	private: System::Windows::Forms::Button^ num1;
	private: System::Windows::Forms::Button^ num2;
	private: System::Windows::Forms::Button^ num3;
	private: System::Windows::Forms::Button^ plus;
	protected:




	private: System::Windows::Forms::Button^ num4;
	private: System::Windows::Forms::Button^ num5;
	private: System::Windows::Forms::Button^ num6;
	private: System::Windows::Forms::Button^ minus;





	private: System::Windows::Forms::Button^ num7;
	private: System::Windows::Forms::Button^ num8;
	private: System::Windows::Forms::Button^ num9;
	private: System::Windows::Forms::Button^ star;
	private: System::Windows::Forms::Button^ brackets;






	private: System::Windows::Forms::Button^ num0;
	private: System::Windows::Forms::Button^ modulus;




	private: System::Windows::Forms::Button^ slash;
	private: System::Windows::Forms::Button^ dot;
	private: System::Windows::Forms::Button^ clear_all;
	private: System::Windows::Forms::Button^ equal;




	private: System::Windows::Forms::Button^ clear;
	private: System::Windows::Forms::Label^ title;
	private: System::Windows::Forms::Label^ answer;




	private: System::ComponentModel::IContainer^ components;





	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>


#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			System::ComponentModel::ComponentResourceManager^ resources = (gcnew System::ComponentModel::ComponentResourceManager(Calculator::typeid));
			this->input = (gcnew System::Windows::Forms::TextBox());
			this->num1 = (gcnew System::Windows::Forms::Button());
			this->num2 = (gcnew System::Windows::Forms::Button());
			this->num3 = (gcnew System::Windows::Forms::Button());
			this->plus = (gcnew System::Windows::Forms::Button());
			this->num4 = (gcnew System::Windows::Forms::Button());
			this->num5 = (gcnew System::Windows::Forms::Button());
			this->num6 = (gcnew System::Windows::Forms::Button());
			this->minus = (gcnew System::Windows::Forms::Button());
			this->num7 = (gcnew System::Windows::Forms::Button());
			this->num8 = (gcnew System::Windows::Forms::Button());
			this->num9 = (gcnew System::Windows::Forms::Button());
			this->star = (gcnew System::Windows::Forms::Button());
			this->brackets = (gcnew System::Windows::Forms::Button());
			this->num0 = (gcnew System::Windows::Forms::Button());
			this->modulus = (gcnew System::Windows::Forms::Button());
			this->slash = (gcnew System::Windows::Forms::Button());
			this->dot = (gcnew System::Windows::Forms::Button());
			this->clear_all = (gcnew System::Windows::Forms::Button());
			this->equal = (gcnew System::Windows::Forms::Button());
			this->clear = (gcnew System::Windows::Forms::Button());
			this->title = (gcnew System::Windows::Forms::Label());
			this->answer = (gcnew System::Windows::Forms::Label());
			this->SuspendLayout();
			// 
			// input
			// 
			this->input->Anchor = static_cast<System::Windows::Forms::AnchorStyles>((System::Windows::Forms::AnchorStyles::Bottom | System::Windows::Forms::AnchorStyles::Right));
			this->input->BackColor = System::Drawing::Color::LightCyan;
			this->input->Cursor = System::Windows::Forms::Cursors::IBeam;
			this->input->Font = (gcnew System::Drawing::Font(L"Arial", 15, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->input->Location = System::Drawing::Point(41, 46);
			this->input->Name = L"input";
			this->input->Size = System::Drawing::Size(294, 36);
			this->input->TabIndex = 0;
			// 
			// num1
			// 
			this->num1->AccessibleName = L"";
			this->num1->BackColor = System::Drawing::SystemColors::GradientActiveCaption;
			this->num1->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 10, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->num1->Location = System::Drawing::Point(41, 120);
			this->num1->Name = L"num1";
			this->num1->Size = System::Drawing::Size(69, 49);
			this->num1->TabIndex = 1;
			this->num1->TabStop = false;
			this->num1->Text = L"1";
			this->num1->UseVisualStyleBackColor = false;
			this->num1->Click += gcnew System::EventHandler(this, &Calculator::num1_Click);
			// 
			// num2
			// 
			this->num2->BackColor = System::Drawing::SystemColors::GradientActiveCaption;
			this->num2->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 10, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->num2->Location = System::Drawing::Point(116, 120);
			this->num2->Name = L"num2";
			this->num2->Size = System::Drawing::Size(69, 49);
			this->num2->TabIndex = 2;
			this->num2->TabStop = false;
			this->num2->Text = L"2";
			this->num2->UseVisualStyleBackColor = false;
			this->num2->Click += gcnew System::EventHandler(this, &Calculator::num2_Click);
			// 
			// num3
			// 
			this->num3->BackColor = System::Drawing::SystemColors::GradientActiveCaption;
			this->num3->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 10, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->num3->Location = System::Drawing::Point(191, 120);
			this->num3->Name = L"num3";
			this->num3->Size = System::Drawing::Size(69, 49);
			this->num3->TabIndex = 3;
			this->num3->TabStop = false;
			this->num3->Text = L"3";
			this->num3->UseVisualStyleBackColor = false;
			this->num3->Click += gcnew System::EventHandler(this, &Calculator::num3_Click);
			// 
			// plus
			// 
			this->plus->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(255)), static_cast<System::Int32>(static_cast<System::Byte>(192)),
				static_cast<System::Int32>(static_cast<System::Byte>(128)));
			this->plus->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 10, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->plus->Location = System::Drawing::Point(266, 120);
			this->plus->Name = L"plus";
			this->plus->Size = System::Drawing::Size(69, 49);
			this->plus->TabIndex = 4;
			this->plus->TabStop = false;
			this->plus->Text = L"+";
			this->plus->UseVisualStyleBackColor = false;
			this->plus->Click += gcnew System::EventHandler(this, &Calculator::plus_Click);
			// 
			// num4
			// 
			this->num4->BackColor = System::Drawing::SystemColors::GradientActiveCaption;
			this->num4->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 10, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->num4->Location = System::Drawing::Point(41, 175);
			this->num4->Name = L"num4";
			this->num4->Size = System::Drawing::Size(69, 49);
			this->num4->TabIndex = 5;
			this->num4->TabStop = false;
			this->num4->Text = L"4";
			this->num4->UseVisualStyleBackColor = false;
			this->num4->Click += gcnew System::EventHandler(this, &Calculator::num4_Click);
			// 
			// num5
			// 
			this->num5->BackColor = System::Drawing::SystemColors::GradientActiveCaption;
			this->num5->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 10, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->num5->Location = System::Drawing::Point(116, 175);
			this->num5->Name = L"num5";
			this->num5->Size = System::Drawing::Size(69, 49);
			this->num5->TabIndex = 6;
			this->num5->TabStop = false;
			this->num5->Text = L"5";
			this->num5->UseVisualStyleBackColor = false;
			this->num5->Click += gcnew System::EventHandler(this, &Calculator::num5_Click);
			// 
			// num6
			// 
			this->num6->BackColor = System::Drawing::SystemColors::GradientActiveCaption;
			this->num6->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 10, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->num6->Location = System::Drawing::Point(191, 175);
			this->num6->Name = L"num6";
			this->num6->Size = System::Drawing::Size(69, 49);
			this->num6->TabIndex = 7;
			this->num6->TabStop = false;
			this->num6->Text = L"6";
			this->num6->UseVisualStyleBackColor = false;
			this->num6->Click += gcnew System::EventHandler(this, &Calculator::num6_Click);
			// 
			// minus
			// 
			this->minus->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(255)), static_cast<System::Int32>(static_cast<System::Byte>(192)),
				static_cast<System::Int32>(static_cast<System::Byte>(128)));
			this->minus->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 10, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->minus->Location = System::Drawing::Point(266, 175);
			this->minus->Name = L"minus";
			this->minus->Size = System::Drawing::Size(69, 49);
			this->minus->TabIndex = 8;
			this->minus->TabStop = false;
			this->minus->Text = L"-";
			this->minus->UseVisualStyleBackColor = false;
			this->minus->Click += gcnew System::EventHandler(this, &Calculator::minus_Click);
			// 
			// num7
			// 
			this->num7->BackColor = System::Drawing::SystemColors::GradientActiveCaption;
			this->num7->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 10, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->num7->Location = System::Drawing::Point(41, 230);
			this->num7->Name = L"num7";
			this->num7->Size = System::Drawing::Size(69, 49);
			this->num7->TabIndex = 9;
			this->num7->TabStop = false;
			this->num7->Text = L"7";
			this->num7->UseVisualStyleBackColor = false;
			this->num7->Click += gcnew System::EventHandler(this, &Calculator::num7_Click);
			// 
			// num8
			// 
			this->num8->BackColor = System::Drawing::SystemColors::GradientActiveCaption;
			this->num8->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 10, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->num8->Location = System::Drawing::Point(116, 230);
			this->num8->Name = L"num8";
			this->num8->Size = System::Drawing::Size(69, 49);
			this->num8->TabIndex = 10;
			this->num8->TabStop = false;
			this->num8->Text = L"8";
			this->num8->UseVisualStyleBackColor = false;
			this->num8->Click += gcnew System::EventHandler(this, &Calculator::num8_Click);
			// 
			// num9
			// 
			this->num9->BackColor = System::Drawing::SystemColors::GradientActiveCaption;
			this->num9->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 10, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->num9->Location = System::Drawing::Point(191, 230);
			this->num9->Name = L"num9";
			this->num9->Size = System::Drawing::Size(69, 49);
			this->num9->TabIndex = 11;
			this->num9->TabStop = false;
			this->num9->Text = L"9";
			this->num9->UseVisualStyleBackColor = false;
			this->num9->Click += gcnew System::EventHandler(this, &Calculator::num9_Click);
			// 
			// star
			// 
			this->star->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(255)), static_cast<System::Int32>(static_cast<System::Byte>(192)),
				static_cast<System::Int32>(static_cast<System::Byte>(128)));
			this->star->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 10, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->star->Location = System::Drawing::Point(266, 230);
			this->star->Name = L"star";
			this->star->Size = System::Drawing::Size(69, 49);
			this->star->TabIndex = 12;
			this->star->TabStop = false;
			this->star->Text = L"*";
			this->star->UseVisualStyleBackColor = false;
			this->star->Click += gcnew System::EventHandler(this, &Calculator::star_Click);
			// 
			// brackets
			// 
			this->brackets->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(255)), static_cast<System::Int32>(static_cast<System::Byte>(192)),
				static_cast<System::Int32>(static_cast<System::Byte>(128)));
			this->brackets->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 10, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->brackets->Location = System::Drawing::Point(41, 285);
			this->brackets->Name = L"brackets";
			this->brackets->Size = System::Drawing::Size(69, 49);
			this->brackets->TabIndex = 13;
			this->brackets->TabStop = false;
			this->brackets->Text = L"( )";
			this->brackets->UseVisualStyleBackColor = false;
			this->brackets->Click += gcnew System::EventHandler(this, &Calculator::brackets_Click);
			// 
			// num0
			// 
			this->num0->BackColor = System::Drawing::SystemColors::GradientActiveCaption;
			this->num0->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 10, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->num0->Location = System::Drawing::Point(116, 285);
			this->num0->Name = L"num0";
			this->num0->Size = System::Drawing::Size(69, 49);
			this->num0->TabIndex = 14;
			this->num0->TabStop = false;
			this->num0->Text = L"0";
			this->num0->UseVisualStyleBackColor = false;
			this->num0->Click += gcnew System::EventHandler(this, &Calculator::num0_Click);
			// 
			// modulus
			// 
			this->modulus->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(255)), static_cast<System::Int32>(static_cast<System::Byte>(192)),
				static_cast<System::Int32>(static_cast<System::Byte>(128)));
			this->modulus->BackgroundImageLayout = System::Windows::Forms::ImageLayout::Center;
			this->modulus->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 10, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->modulus->Location = System::Drawing::Point(191, 285);
			this->modulus->Name = L"modulus";
			this->modulus->Size = System::Drawing::Size(69, 49);
			this->modulus->TabIndex = 15;
			this->modulus->TabStop = false;
			this->modulus->Text = L"%";
			this->modulus->UseVisualStyleBackColor = false;
			this->modulus->Click += gcnew System::EventHandler(this, &Calculator::modulus_Click);
			// 
			// slash
			// 
			this->slash->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(255)), static_cast<System::Int32>(static_cast<System::Byte>(192)),
				static_cast<System::Int32>(static_cast<System::Byte>(128)));
			this->slash->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 10, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->slash->Location = System::Drawing::Point(266, 285);
			this->slash->Name = L"slash";
			this->slash->Size = System::Drawing::Size(69, 49);
			this->slash->TabIndex = 16;
			this->slash->TabStop = false;
			this->slash->Text = L"/";
			this->slash->UseVisualStyleBackColor = false;
			this->slash->Click += gcnew System::EventHandler(this, &Calculator::slash_Click);
			// 
			// dot
			// 
			this->dot->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(255)), static_cast<System::Int32>(static_cast<System::Byte>(192)),
				static_cast<System::Int32>(static_cast<System::Byte>(128)));
			this->dot->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 11, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->dot->Location = System::Drawing::Point(41, 340);
			this->dot->Name = L"dot";
			this->dot->Size = System::Drawing::Size(69, 49);
			this->dot->TabIndex = 17;
			this->dot->TabStop = false;
			this->dot->Text = L".";
			this->dot->UseVisualStyleBackColor = false;
			this->dot->Click += gcnew System::EventHandler(this, &Calculator::dot_Click);
			// 
			// clear_all
			// 
			this->clear_all->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(255)), static_cast<System::Int32>(static_cast<System::Byte>(128)),
				static_cast<System::Int32>(static_cast<System::Byte>(128)));
			this->clear_all->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 10, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->clear_all->Location = System::Drawing::Point(116, 340);
			this->clear_all->Name = L"clear_all";
			this->clear_all->Size = System::Drawing::Size(69, 49);
			this->clear_all->TabIndex = 18;
			this->clear_all->TabStop = false;
			this->clear_all->Text = L"CA";
			this->clear_all->UseVisualStyleBackColor = false;
			this->clear_all->Click += gcnew System::EventHandler(this, &Calculator::CA_Click);
			// 
			// equal
			// 
			this->equal->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(255)), static_cast<System::Int32>(static_cast<System::Byte>(128)),
				static_cast<System::Int32>(static_cast<System::Byte>(128)));
			this->equal->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 13, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->equal->Location = System::Drawing::Point(266, 340);
			this->equal->Name = L"equal";
			this->equal->Size = System::Drawing::Size(69, 49);
			this->equal->TabIndex = 20;
			this->equal->TabStop = false;
			this->equal->Text = L"=";
			this->equal->UseVisualStyleBackColor = false;
			this->equal->Click += gcnew System::EventHandler(this, &Calculator::equal_Click);
			// 
			// clear
			// 
			this->clear->BackColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(255)), static_cast<System::Int32>(static_cast<System::Byte>(128)),
				static_cast<System::Int32>(static_cast<System::Byte>(128)));
			this->clear->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 10.2F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->clear->Location = System::Drawing::Point(191, 340);
			this->clear->Name = L"clear";
			this->clear->Size = System::Drawing::Size(69, 49);
			this->clear->TabIndex = 19;
			this->clear->TabStop = false;
			this->clear->Text = L"C";
			this->clear->UseVisualStyleBackColor = false;
			this->clear->Click += gcnew System::EventHandler(this, &Calculator::C_Click);
			// 
			// title
			// 
			this->title->AutoSize = true;
			this->title->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 9, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->title->Location = System::Drawing::Point(38, 25);
			this->title->Name = L"title";
			this->title->Size = System::Drawing::Size(147, 18);
			this->title->TabIndex = 21;
			this->title->Text = L"Enter the expression:";
			// 
			// answer
			// 
			this->answer->AutoSize = true;
			this->answer->Font = (gcnew System::Drawing::Font(L"Arial", 8, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->answer->ForeColor = System::Drawing::Color::Red;
			this->answer->Location = System::Drawing::Point(41, 85);
			this->answer->Name = L"answer";
			this->answer->Size = System::Drawing::Size(0, 19);
			this->answer->TabIndex = 22;
			this->answer->TextAlign = System::Drawing::ContentAlignment::MiddleCenter;
			this->answer->UseCompatibleTextRendering = true;
			// 
			// Calculator
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(8, 16);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(377, 427);
			this->Controls->Add(this->answer);
			this->Controls->Add(this->title);
			this->Controls->Add(this->equal);
			this->Controls->Add(this->clear);
			this->Controls->Add(this->clear_all);
			this->Controls->Add(this->dot);
			this->Controls->Add(this->num1);
			this->Controls->Add(this->slash);
			this->Controls->Add(this->modulus);
			this->Controls->Add(this->num0);
			this->Controls->Add(this->brackets);
			this->Controls->Add(this->star);
			this->Controls->Add(this->num9);
			this->Controls->Add(this->num8);
			this->Controls->Add(this->num7);
			this->Controls->Add(this->minus);
			this->Controls->Add(this->num6);
			this->Controls->Add(this->num5);
			this->Controls->Add(this->num4);
			this->Controls->Add(this->plus);
			this->Controls->Add(this->num3);
			this->Controls->Add(this->num2);
			this->Controls->Add(this->input);
			this->FormBorderStyle = System::Windows::Forms::FormBorderStyle::FixedSingle;
			this->Icon = (cli::safe_cast<System::Drawing::Icon^>(resources->GetObject(L"$this.Icon")));
			this->MaximizeBox = false;
			this->Name = L"Calculator";
			this->StartPosition = System::Windows::Forms::FormStartPosition::CenterScreen;
			this->Text = L"Calculator";
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion

		private:
			System::Void num1_Click(System::Object^ sender, System::EventArgs^ e) {
				input->Text += "1";
				answer->Text = "";
			}
			System::Void num2_Click(System::Object^ sender, System::EventArgs^ e) {
				input->Text += "2";
				answer->Text = "";
			}
			System::Void num3_Click(System::Object^ sender, System::EventArgs^ e) {
				input->Text += "3";
				answer->Text = "";
			}
			System::Void num4_Click(System::Object^ sender, System::EventArgs^ e) {
				input->Text += "4";
				answer->Text = "";
			}
			System::Void num5_Click(System::Object^ sender, System::EventArgs^ e) {
				input->Text += "5";
				answer->Text = "";
			}
			System::Void num6_Click(System::Object^ sender, System::EventArgs^ e) {
				input->Text += "6";
				answer->Text = "";
			}
			System::Void num7_Click(System::Object^ sender, System::EventArgs^ e) {
				input->Text += "7";
				answer->Text = "";
			}
			System::Void num8_Click(System::Object^ sender, System::EventArgs^ e) {
				input->Text += "8";
				answer->Text = "";
			}
			System::Void num9_Click(System::Object^ sender, System::EventArgs^ e) {
				input->Text += "9";
				answer->Text = "";
			}
			System::Void num0_Click(System::Object^ sender, System::EventArgs^ e) {
				input->Text += "0";
				answer->Text = "";
			}
			System::Void plus_Click(System::Object^ sender, System::EventArgs^ e) {
				input->Text += "+";
				answer->Text = "";
			}
			System::Void minus_Click(System::Object^ sender, System::EventArgs^ e) {
				input->Text += "-";
				answer->Text = "";
			}
			System::Void star_Click(System::Object^ sender, System::EventArgs^ e) {
				input->Text +="*";
				answer->Text = "";
			}
			System::Void slash_Click(System::Object^ sender, System::EventArgs^ e) {
				input->Text += "/";
				answer->Text = "";
			}
			int i = 0;
			System::Void brackets_Click(System::Object^ sender, System::EventArgs^ e) {
				if (i % 2 == 0) {
					input->Text += "(";
					i++;
				}
				else {
					input->Text += ")";
					i++;
				}
				answer->Text = "";
			}
			System::Void modulus_Click(System::Object^ sender, System::EventArgs^ e) {
				input->Text +="%";
				answer->Text = "";
			}
			System::Void dot_Click(System::Object^ sender, System::EventArgs^ e) {
				input->Text +=".";
				answer->Text = "";
					
			}
			System::Void C_Click(System::Object^ sender, System::EventArgs^ e) {
				String^ s = input->Text;
				if (s->Length > 0) {
					s = s->Substring(0, s->Length - 1);
					input->Text = s;
					answer->Text = "";
				}
			}
			System::Void CA_Click(System::Object^ sender, System::EventArgs^ e) {
				input->Text="";
				answer->Text = "";
			}
			System::Void equal_Click(System::Object^ sender, System::EventArgs^ e) {
				char expstr[256];
				parser object;
					String^ s1 = input->Text;
					string  s2 = msclr::interop::marshal_as<std::string>(s1);
					for (int i = 0; i < s2.length(); i++)expstr[i] = s2[i];
					double ans = object.evaluate_exp(expstr);
					if (*object.errormsg) {
						string str = object.errormsg;
						String^ Str = gcnew String(str.c_str());
						answer->Font = (gcnew System::Drawing::Font(L"Arial", 8, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
							static_cast<System::Byte>(0)));
						answer->ForeColor = System::Drawing::Color::Red;
						answer->Text ="Error!: "+Str;
					}
					else {
						answer->Font = (gcnew System::Drawing::Font(L"Arial", 11, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
							static_cast<System::Byte>(0)));
						answer->ForeColor = System::Drawing::Color::FromArgb(static_cast<System::Int32>(static_cast<System::Byte>(0)), static_cast<System::Int32>(static_cast<System::Byte>(192)),
							static_cast<System::Int32>(static_cast<System::Byte>(0)));
						answer->Text="Answer: "+ans;
					}
			}

};
}
