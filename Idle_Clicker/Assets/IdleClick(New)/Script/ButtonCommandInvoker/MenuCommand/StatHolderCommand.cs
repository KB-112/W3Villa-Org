using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace IdleClicker
{
    public class StatHolderCommand : IButtonCommander
    {
        private StatInputConfig statInputConfig;
        private ShopConfig shopInputConfig;
        private StatHolderFunction statHolderFunction;
        private List<Button> playerButtons;
        private MainGameInitConfig mainGameInitConfig;
        public StatHolderCommand(StatInputConfig statInputConfig , ShopConfig shopInputConfig,StatHolderFunction statHolderFunction, MainGameInitConfig mainGameInitConfig,List<Button> playerButtons)
        {
            this.statInputConfig = statInputConfig;
            this.statHolderFunction = statHolderFunction;
            this.shopInputConfig= shopInputConfig;
            this.playerButtons = playerButtons;
            this.mainGameInitConfig = mainGameInitConfig;
        }

        public void StoreButtonListenerCommand()
        {
            foreach (var button in playerButtons)
            {
                string currentButtonName = button.name;

                button.onClick.AddListener(() =>
                { statHolderFunction.StatInfo(statInputConfig, shopInputConfig,currentButtonName); });
            }
        }
        
    }
}
