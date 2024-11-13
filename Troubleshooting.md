# Probleemoplossing .NET Workloads

Als je problemen ondervindt met ontbrekende .NET workloads of tools, volg dan deze stappen:

### 1. **Controleer de .NET SDK Versie**
Zorg ervoor dat je de juiste versie van de .NET SDK gebruikt. Dit project vereist .NET versie 8.0.401 of hoger. Voer het volgende uit om je versie te controleren:

dotnet --version

### 2. Navigeer naar de server Folder
Omdat we twee mappen hebben (server en client), moet je in de server map zijn om de workload updates uit te voeren. Navigeer eerst naar de server map:

cd server

### 3. Werk de Vereiste Workloads Bij
Als er ontbrekende workloads zijn, kun je ze installeren met het volgende commando:
dotnet workload install

### 4. Werk .NET Workloads Bij
Als de workloads verouderd zijn, werk ze dan bij met:

dotnet workload update

### 5. Herstart je IDE
Na het bijwerken van de workloads, herstart je je IDE (bijv. Visual Studio of Visual Studio Code) om de wijzigingen toe te passen.
