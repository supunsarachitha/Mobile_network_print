
# 🖨️ Mobile Network Print

A simple demo application built with **Xamarin** to send and print strings over a local network. This project is ideal for learning how to implement basic network communication between devices and simulate remote printing functionality.

---

## 📦 Overview

This project demonstrates:

- Sending string data over a local network
- Basic socket programming in C#
- Simulated print functionality for mobile or desktop environments

---

## 🚀 Getting Started

### Prerequisites

- .NET Framework or .NET Core SDK
- Visual Studio (recommended)
- Two devices on the same local network (for testing)

### How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/supunsarachitha/Mobile_network_print.git
   ```

2. Open `Mobile_network_print.sln` in Visual Studio.

3. Build and run the project.

4. Configure IP and port settings as needed to match your local network.

---

## 🧪 Example Usage

```csharp
TcpClient client = new TcpClient("192.168.1.100", 9000);
NetworkStream stream = client.GetStream();
byte[] data = Encoding.ASCII.GetBytes("Hello, printer!");
stream.Write(data, 0, data.Length);
```

---

## 📁 Project Structure

```
Mobile_network_print/
├── Mobile_network_print.sln       # Solution file
├── .gitignore                     # Git settings
├── .gitattributes                 # Git attributes
├── README.md                      # Project documentation
└── Mobile_network_print/          # Source code folder
```

---

## 📄 License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

---

## 👤 Author

Created by [Supun Sarachitha](https://github.com/supunsarachitha). Feel free to fork, contribute, or reach out!

---

## 🙌 Contributions

Pull requests are welcome! If you’d like to add features like file printing, encryption, or mobile UI integration, go ahead and submit a PR.

---

## 📬 Contact

For questions or suggestions, open an issue or connect via GitHub.
```
