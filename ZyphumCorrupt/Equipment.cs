using System;

public class Equipment
{
    #region Members

    //This will be used to add to character stats temporarily
    private int boost;
    //This will be sourced from a dictionary in global namespace
    private string boostType;

    #endregion

    #region Getters Setters

    public int GetBoost()
    {
        return boost;
    }
    public void SetBoost(int interger)
    {
        boost = interger;
    }
    public string GetBoostType()
    {
        return boostType;
    }
    public void SetBoostType(string type)
    {
        boostType = type;
    }

    #endregion

    public Equipment()
	{
        boost = 0;
        boostType = "Null";
	}
}
