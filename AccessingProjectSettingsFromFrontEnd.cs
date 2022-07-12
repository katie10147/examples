// 1. 

            if (UmiContext.Current != null)
            {
                if (UmiContext.Current.ModuleProjectSettings.Get<ExtraEnergyProjectSettings>() != null)
                {
                    var projectSettings = UmiContext.Current.ModuleProjectSettings.Get<ExtraEnergyProjectSettings>();
                    return projectSettings.StreetLightingByLayer;
                }
            }

// 2. 


	public object? StreetInformation1 => UmiContext.Current != null ? UmiContext.Current.ModuleProjectSettings.Get<ExtraEnergyProjectSettings>().StreetLightingByLayer : default(object?);

// 3. 

	private void RunGetStreetLengthsCommand()
        {
            RhinoApp.RunScript("UmiGetStreetLengths", echo: true);
            var projectSettings = UmiContext.Current.ModuleProjectSettings.Get<ExtraEnergyProjectSettings>();
            streetInformation = projectSettings.StreetLightingByLayer;

        }
