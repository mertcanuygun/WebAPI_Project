# WebAPI_Project
Sample API project for vehicles

This Project aims showing API app. There are 3 different vehicle type and you can call type a vehicle by their colour. Also cars can be deleted as well as they can be called by their ID's.

1- Model folder is created with entities, DTO's and VM's. BaseVehicle abstract class is inherited to other classes. Note that, DTO folder was created for headlight changes because at the beginning I planned it to be a HttpPatch method. Then I changed to be HttpPost method with a different approach. 
   <br>
2- Infrastructure folder was created. Seed Data classes are opened with samples. AppDbContext class is builded with seed data implementation.
   Then Mapper folder was created. It was meant for Update method but then as I mentioned I cancelled this approach. Then I found a way to use this library for headlight change method.
   Last but not least, Repositories are created. I used Linq expressions for filtering and selecting data. AppDbContext class is injected in all of the repositories.
   Also, I establish these repositories with Interface Segregation Principle while trying to apply other SOLID approachs throughout the entire project.
   <br>
3- Controller folder is created with necessary actions.

   
