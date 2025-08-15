# QRGen

QRGen is a Blazor WebAssembly application for generating customizable QR codes. Users can enter a website URL, optionally upload an image, and download the generated QR code in SVG or PNG format.

## Features
- Generate QR codes for any website URL
- Optional image upload to embed in QR code
- Download QR code as SVG or PNG
- Responsive UI with Bootstrap styling

## Prerequisites
- [.NET 9.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
- [Node.js](https://nodejs.org/) (optional, for frontend tooling)
- Docker (optional, for containerized deployment)

## Getting Started

### Build and Run Locally
1. Clone the repository:
   ```bash
   git clone <repo-url>
   cd QRGen
   ```
2. Restore dependencies and run:
   ```bash
   dotnet run --project QRGen/QRGen.csproj
   ```
3. Open your browser and navigate to `http://localhost:5000` (or the port shown in the console).

### Docker Deployment
1. Build the Docker image:
   ```bash
   docker build -t qrgen .
   ```
2. Run the container:
   ```bash
   docker run -d -p 8080:80 qrgen
   ```
3. Access the app at `http://localhost:8080`

## Project Structure
- `QRGen/Pages/` - Blazor pages (main UI logic)
- `QRGen/Layout/` - Layout components
- `QRGen/wwwroot/` - Static files (JS, CSS, images)
- `QRGen/Program.cs` - App entry point
- `QRGen/Dockerfile` - Docker configuration

## Customization
- Modify `Home.razor` for UI changes or QR code logic
- Update `wwwroot/download.js` for custom JS interop
- Style with `wwwroot/css/app.css` or add new styles

## License
MIT License

---

For questions or contributions, please open an issue or pull request on GitHub.

