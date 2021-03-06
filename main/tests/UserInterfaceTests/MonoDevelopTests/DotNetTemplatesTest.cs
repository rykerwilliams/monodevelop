﻿//
// MonoDevelopTemplatesTest.cs
//
// Author:
//       Manish Sinha <manish.sinha@xamarin.com>
//
// Copyright (c) 2015 Xamarin Inc.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using MonoDevelop.Components.AutoTest;
using MonoDevelop.Ide.Commands;
using NUnit.Framework;

namespace UserInterfaceTests
{
	public class MonoDevelopTemplatesTest : CreateBuildTemplatesTestBase
	{
		readonly string dotNetCategory = ".NET";

		[Test]
		public void TestCreateBuildConsoleProject ()
		{
			RunDotNetTests ("Console Project", EmptyAction);
		}

		[Test]
		public void TestCreateBuildGtkSharp20Project ()
		{
			RunDotNetTests ("Gtk# 2.0 Project", EmptyAction);
		}

		[Test]
		public void TestCreateBuildLibrary ()
		{
			RunDotNetTests ("Library", EmptyAction);
		}

		[Test]
		public void TestCreateBuildNUnitLibraryProject ()
		{
			RunDotNetTests ("NUnit Library Project", WaitForPackageUpdate);
		}

		void RunDotNetTests (string templateName, Action beforeBuild)
		{
			CreateBuildProject (GenerateProjectName (templateName), OtherCategoryRoot, dotNetCategory, GeneralKindRoot, templateName, beforeBuild);
		}
	}
}
