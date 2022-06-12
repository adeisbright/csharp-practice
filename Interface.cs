interface ISchool
{
    void printSchoolName();

    //string setCategory(string text); 
}

interface IOrganization : ISchool
{
    void addMembers(string[] names);
}