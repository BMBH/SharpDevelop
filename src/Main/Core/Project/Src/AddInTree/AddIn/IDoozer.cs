﻿// <file>
//     <copyright see="prj:///doc/copyright.txt">2002-2005 AlphaSierraPapa</copyright>
//     <license see="prj:///doc/license.txt">GNU General Public License</license>
//     <owner name="Mike Krüger" email="mike@icsharpcode.net"/>
//     <version>$Revision$</version>
// </file>

using System;
using System.Collections;

namespace ICSharpCode.Core
{
	/// <summary>
	/// Interface for classes that can build objects out of codons.
	/// </summary>
	/// <remarks>http://en.wikipedia.org/wiki/Fraggle_Rock#Doozers</remarks>
	public interface IDoozer
	{
		/// <summary>
		/// Gets if the doozer handles codon conditions on its own.
		/// If this property return false, the item is excluded when the condition is not met.
		/// </summary>
		bool HandleConditions { get; }
		
		object BuildItem(object caller, Codon codon, ArrayList subItems);
	}
}
