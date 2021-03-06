﻿namespace ModelViewPresenter.WindowsForms.MasterDetailWithDirectMethodCalls.Model
{
    public class Contact
    {
        public int? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

        public string FullName => $"{LastName}, {FirstName}";
    }
}
