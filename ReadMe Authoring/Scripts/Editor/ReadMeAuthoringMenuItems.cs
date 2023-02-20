using UnityEditor;
using UnityEngine;

namespace RMC.Core.ReadMe.Authoring
{
	/// <summary>
	/// [MenuItems] for <see cref="ReadMe"/>
	/// </summary>
	public static class ReadMeAuthoringMenuItems
	{
		//  Other Methods [FIRST PRIORITY] ------------------

		
		
		
		
		
		
		[MenuItem(
			ReadMeConstants.MenuItemPathWindow + "/Authoring/" +
			ReadMeConstants.Open + " ReadMe", 
			isValidateFunction:false,
			ReadMeConstants.MenuPriority_Primary + 1)]
		public static void SelectReadmes()
		{
			ReadMeHelper.SelectReadmes();
		}
		
		[MenuItem(
			ReadMeConstants.MenuItemPathWindow + "/Authoring/" +
			ReadMeConstants.Open + " ReadMe", 
			isValidateFunction:true,
			ReadMeConstants.MenuPriority_Primary + 1)]
		public static bool SelectReadmes_ValidationFunction()
		{
			return ReadMeHelper.SelectReadmes_ValidationFunction();
		}
		

		[MenuItem(
			ReadMeConstants.MenuItemPathWindow + "/Authoring/" +
			"Load Layout (10x16)", 
			isValidateFunction:false,
			ReadMeConstants.MenuPriority_Primary + 2)]
		public static void LoadExampleLayout_10x16()
		{
			//Keep hardcode here, in case user needs to customize value
			string guid = "3ecd0049f50df9c428b9fa47981a9a12";
			string path = AssetDatabase.GUIDToAssetPath(guid);
			ReadMeReflectionUtility.UnityEditor_WindowLayout_LoadWindowLayout(path);
		}
		
		
		[MenuItem(
			ReadMeConstants.MenuItemPathWindow + "/Authoring/" +
			"Load Layout (16x10)", 
			isValidateFunction:false,
			ReadMeConstants.MenuPriority_Primary + 2)]
		public static void LoadExampleLayout_16x10()
		{
			//Keep hardcode here, in case user needs to customize value
			string guid = "302b25cf337dea943a15941cc4453446";
			string path = AssetDatabase.GUIDToAssetPath(guid);
			ReadMeReflectionUtility.UnityEditor_WindowLayout_LoadWindowLayout(path);
		}
		
		
		
		
		
				
		//  Other Methods [SECOND PRIORITY] ------------------

		
		[MenuItem( 
			ReadMeConstants.MenuItemPathWindow + "/Authoring/" + "Copy Guid", 
			isValidateFunction:false,
			priority = ReadMeConstants.MenuPriority_Secondary + 1 )]
		public static void CopyGuidToClipboard()
		{
			ReadMeHelper.CopyGuidToClipboard();
		}
		
		
		[MenuItem( 
			ReadMeConstants.MenuItemPathWindow + "/Authoring/" + "Copy Guid", 
			isValidateFunction:true,
			priority = ReadMeConstants.MenuPriority_Secondary + 2 )]
		public static bool CopyGuidToClipboard_ValidationFunction()
		{
			return ReadMeHelper.CopyGuidToClipboard_ValidationFunction();
		
		}



		
		[MenuItem(
			ReadMeConstants.MenuItemPathWindow + "/Authoring/" +
			"Create New ReadMe", 
			isValidateFunction:false,
			ReadMeConstants.MenuPriority_Secondary + 3)]
		public static void CreateNewReadMe()
		{
			ReadMeHelper.CreateNewReadMe("New ReadMe");
		}


		[MenuItem(
			ReadMeConstants.MenuItemPathWindow + "/Authoring/" +
			"Restart Unity Editor", 
			isValidateFunction:false,
			ReadMeConstants.MenuPriority_Secondary + 4)]
		public static void RestartUnityEditor()
		{
			ReadMeHelper.RestartUnityEditor();
			
		}
	}
}
