using Zoo_management_System;

internal static class AnimalsViewControllerHelpers
{
    public static void OpenAnimalsView(ZooManager zooManager)
    {
        AnimalsView animalsView = new AnimalsView(zooManager);
        animalsView.Show();
    }
}