using lab16._10.DIP_Example;
using lab16._10.ISP_Example;
using lab16._10.ISP_Example.Interfaces;
using lab16._10.LSP_Example;
using lab16._10.OCP_Exporter;
using lab16._10.SRP_example;
//SRP
UserValidator validator = new UserValidator();
IUseRepository repository = new lab16._10.SRP_example.UserRepository();
UserController controller = new UserController(validator, repository);
controller.CreateUser("John Doe", "johndoe@example.com", "password123");

//OCP
string[] data = { "Jane Doe", "Bob Smith" };
FIleExporterOCP pdf = new PdfFileExport();
FIleExporterOCP excel = new ExcelFileExporter();

foreach (string item in data)
{
    pdf.Export(item);
    excel.Export(item);
}
//LSP
BirdLSP penguin = new PenguinLSP();
penguin.Eat();
penguin.Sleep();
// The following line would violate LSP if uncommented, as PenguinLSP does not implement Fly()
BirdLSP eagle = new EagleLSP();
eagle.Eat();
// Removed the problematic line that tries to call Fly() on a BirdLSP reference
//ISP
IOrderPayment onlineOrder = new OnlineOrder();
onlineOrder.CalculateTotal();
onlineOrder.PayMnent();

//DIP
IUserModelDIP userRepositorys = new lab16._10.DIP_Example.UserRepository();
UserControllerDIP userController = new UserControllerDIP(userRepositorys);
userController.CreateUser();
userController.UpdateUser();
userController.DeleteUser();

