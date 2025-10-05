# Solar Panel AR 🌱

An immersive Augmented Reality application that visualizes real-time solar panel data in 3D space. Built with Unity and AR Foundation, this app bridges renewable energy education with cutting-edge AR technology.

![AR Demo](https://img.shields.io/badge/AR-Enabled-brightgreen)
![Unity](https://img.shields.io/badge/Unity-2021.3.12f1-blue)
![Platform](https://img.shields.io/badge/Platform-Android-green)
![Status](https://img.shields.io/badge/Status-Active-success)

## 🎯 What This App Does

- **Real-time Data Visualization**: Displays live solar panel metrics from ThingSpeak API
- **AR Solar Panel Placement**: Place interactive 3D solar panels in your physical space
- **Dynamic Panel Rotation**: Panels automatically rotate based on real sun angle data
- **Multi-field Data Display**: Shows power output, angles, and sensor readings
- **Mobile AR Experience**: Native Android app with ARCore integration

## 🚀 Quick Start

### Prerequisites

- Android device with ARCore support ([Check compatibility](https://developers.google.com/ar/devices))
- Unity 2021.3.12f1 or later
- Android SDK with API level 24+

### Installation

1. **Download APK** (Quick Start)

   ```bash
   # Download solar.apk from releases
   adb install solar.apk
   ```

2. **Build from Source**
   ```bash
   git clone https://github.com/yourusername/solar-panel-ar.git
   cd solar-panel-ar
   # Open src/ folder in Unity
   # Build and Run for Android
   ```

### Usage

1. Launch the app and grant camera permissions
2. Point your camera at a flat surface (table, floor)
3. Tap when you see AR plane indicators
4. Watch real-time solar panel data and dynamic rotations!

## 🏗️ Technical Architecture

### Core Components

- **Unity AR Foundation 4.2.7**: Cross-platform AR framework
- **ARCore 4.2.7**: Android AR implementation
- **ThingSpeak API**: Real-time IoT data source
- **Newtonsoft.Json**: JSON parsing for API responses

### Project Structure

```
src/
├── Assets/
│   ├── getdata.cs                 # Real-time data fetching & panel control
│   ├── prefab/
│   │   ├── PlaceOnPlane.cs       # AR placement & touch handling
│   │   ├── AR Default Plane.prefab
│   │   └── VIsual Object/        # 3D models & materials
│   ├── Scenes/
│   │   └── SampleScene.unity     # Main AR scene
│   └── Solar Panel.fbx           # 3D solar panel model
├── ProjectSettings/               # Unity configuration
└── Packages/                     # Dependencies
```

## 📊 Data Integration

The app connects to ThingSpeak API for real-time solar data:

- **Endpoint**: `https://api.thingspeak.com/channels/2040586/feeds.json`
- **Update Frequency**: 1-second intervals
- **Data Fields**:
  - Field 1: Power output (W)
  - Field 2: Sun angle (degrees)
  - Fields 3-5: Additional sensor readings

### API Response Flow

1. Fetch latest data from ThingSpeak
2. Parse JSON response with error handling
3. Update UI text elements
4. Calculate rotation delta for 16 solar panels
5. Smooth rotation based on sun angle changes

## 🎮 AR Features

### Plane Detection

- Automatic surface detection using ARRaycastManager
- Visual feedback with plane indicators
- Touch-to-place interaction system

### Object Placement

- Single-tap placement on detected planes
- Prevents multiple simultaneous placements
- World-space positioning with proper scaling

### Real-time Updates

- Live data refresh every second
- Smooth panel rotation animations
- Responsive UI updates

## 🛠️ Development Setup

### Unity Configuration

1. **Install Required Packages**:

   - AR Foundation (4.2.7)
   - ARCore XR Plugin (4.2.7)
   - TextMeshPro (3.0.6+)
   - Newtonsoft.Json

2. **Build Settings**:

   - Platform: Android
   - Scripting Backend: IL2CPP
   - Target Architecture: ARM64
   - Minimum API Level: 24

3. **XR Settings**:
   - Enable ARCore in XR Plug-in Management
   - Configure AR Foundation providers

### Key Scripts

#### `getdata.cs` - Data Manager

```csharp
// Fetches ThingSpeak data and rotates panels
public class getdata : MonoBehaviour
{
    // Real-time API integration
    // JSON parsing and error handling
    // Panel rotation calculations
    // UI updates
}
```

#### `PlaceOnPlane.cs` - AR Controller

```csharp
// Handles AR placement and interactions
public class PlaceOnPlane : MonoBehaviour
{
    // Touch input detection
    // AR raycasting
    // Object instantiation
    // Plane detection feedback
}
```

## 🐛 Troubleshooting

### Common Issues

**AR Not Working**

- Verify ARCore support on your device
- Check camera permissions
- Ensure good lighting conditions
- Try on different surface types

**Data Not Loading**

- Check internet connectivity
- Verify ThingSpeak API status
- Restart the application
- Check for API rate limits

**Build Errors**

- Ensure Android SDK is properly configured
- Verify Unity version compatibility
- Check package versions
- Clear Library folder if needed

### Performance Optimization

- API calls limited to 1Hz to preserve battery
- Efficient panel rotation calculations
- Optimized AR rendering pipeline
- Memory management for mobile devices

## 🎯 Roadmap

### Immediate Goals

- [ ] Enhanced error handling and user feedback
- [ ] iOS support with ARKit
- [ ] Improved 3D models and animations
- [ ] Historical data visualization
- [ ] Better UI/UX design

### Future Features

- [ ] Multi-user AR sessions
- [ ] Cloud data synchronization
- [ ] Advanced AR interactions (scaling, manual rotation)
- [ ] Integration with real solar monitoring systems
- [ ] Offline mode with cached data

## 🤝 Contributing

We welcome contributions! Here's how to get started:

1. **Fork** the repository
2. **Create** a feature branch (`git checkout -b feature/amazing-feature`)
3. **Commit** your changes (`git commit -m 'Add amazing feature'`)
4. **Push** to the branch (`git push origin feature/amazing-feature`)
5. **Open** a Pull Request

### Development Guidelines

- Follow Unity C# coding standards
- Test on multiple Android devices
- Update documentation for new features
- Ensure AR functionality works in various environments
- Add error handling for network operations

## 📱 Device Compatibility

### Minimum Requirements

- **OS**: Android 7.0+ (API 24)
- **RAM**: 3GB recommended
- **ARCore**: Must be supported and installed
- **Camera**: Rear-facing camera required
- **Internet**: For real-time data updates

### Tested Devices

- Samsung Galaxy S21+
- Google Pixel 6
- OnePlus 9 Pro
- Xiaomi Mi 11

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 🙏 Acknowledgments

- **Unity Technologies** for AR Foundation framework
- **Google** for ARCore platform
- **ThingSpeak** for IoT data platform
- **Open Source Community** for invaluable resources and inspiration

## 📞 Support

Need help or have questions?

- 📫 Create an [Issue](https://github.com/tech-helper07/solar-panel-ar/issues)
- 💬 Start a [Discussion](https://github.com/tech-helper07/solar-panel-ar/discussions)
- 📧 Email: sanjains16@gmail.com

## ⭐ Show Your Support

If this project helped you learn AR development or renewable energy visualization, please give it a star! Your support motivates continued development and helps others discover this project.

---

**Built with ❤️ for renewable energy education and AR innovation**

> "Bridging the gap between clean energy and immersive technology, one AR panel at a time."
