﻿using System;
using GameApp;

namespace StereoFramework.GameApp.ECS.components.comps
{
    public class Comp_DestroyOffscreen : IComponent
    {
        private Entity parent;

        public Comp_DestroyOffscreen(Entity p)
        {
            this.SetParentEntity(p);
        }

        public void OnInitialize(App app)
        {

        }

        public void OnAdded()
        {

        }

        public void SetParentEntity(Entity e)
        {
            this.parent = e;
        }
    }
}
