﻿
namespace SeriousGameToolbox.Data.Parameters
{
    public abstract class Parameter
    {
        public string Id { get; private set; }
        public string Caption { get; private set; }

        public Parameter(string id, string caption)
        {
            if (id == null)
            {
                throw new System.ArgumentNullException("id");
            }

            this.Id = id;
            this.Caption = caption;
        }

        public abstract object GetValue();
        public abstract Parameter Clone();
    }
}