using UnityEditor;

namespace RMC.Core.ReadMe.Authoring
{
	/// <summary>
	/// Automatically Load <see cref="ReadMe"/> when Unity opens
	/// </summary>
	
	[InitializeOnLoad]
	public static class ReadMeInitializeOnLoad
	{
		//  Properties ------------------------------------

		
		//  Fields ----------------------------------------
		private static readonly string HasShownReadMe = "RMC.Core.ReadMe.Authoring.HasShownReadMe";
		
		//  Other Methods ---------------------------------
		static ReadMeInitializeOnLoad()
		{
			if (!SessionState.GetBool(HasShownReadMe, false))
			{
				EditorApplication.update += WaitOneFrame;
			}
		}
		

		private static void WaitOneFrame()
		{
			EditorApplication.update -= WaitOneFrame;
			ReadMeHelper.SelectReadmes();
			SessionState.SetBool(HasShownReadMe, true);
		}
	}
}
