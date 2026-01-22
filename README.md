# 🍰 Sweet Spot Dessert Shop - Touchscreen Kiosk System

A comprehensive self-service ordering system built with C# and Windows Forms, featuring QR code authentication, 24+ intuitive screens, and full payment processing capabilities.

![Sweet Spot Kiosk](screenshots/welcome-screen.png)

## 📋 Project Overview

Designed and developed a complete touchscreen kiosk ordering system for Sweet Spot Dessert Shop following ISO 9241 usability standards and WCAG 2.1 accessibility guidelines.

**Course:** Web Development and HCI  
**University:** British University of Bahrain  
**Date:** November 2025  
**Grade:** [Your grade if you want to include it]

## ✨ Key Features

### Customer-Facing Features
- **Intuitive Welcome Screen** with visual appeal and clear call-to-action
- **Category-Based Browsing** (Cakes, Drinks, Specials) with color-coded navigation
- **Product Search** with on-screen QWERTY keyboard
- **Detailed Product Pages** with images, descriptions, and allergen warnings
- **Shopping Basket** with quantity adjustment and order review
- **QR Code Loyalty Card Integration** with automatic discount application
- **Multiple Receipt Options** (Print, Email, or Skip)
- **Auto-Return to Welcome** with timeout protection

### Staff Features
- **Staff Authentication** via QR code ID cards
- **Cleaning Mode** with 60-second auto-timeout
- **Order Management** interface
- **Secure access control**

### Technical Features
- **24+ Interactive Screens** with seamless navigation flow
- **QR Code Scanner Integration** for loyalty cards and staff authentication
- **Session Management** with automatic timeout
- **Error Prevention Design** based on SHERPA analysis
- **Responsive Touch Interface** following ISO 9241-411:2012 standards
- **Accessibility Compliance** (WCAG 2.1 guidelines)

## 🛠️ Technologies Used

- **Language:** C#
- **Framework:** Windows Forms (.NET Framework)
- **IDE:** Visual Studio 2022
- **Libraries:** 
  - QR Code Scanner library
  - System.Drawing for graphics
- **Design Standards:** ISO 9241, WCAG 2.1

## 🎨 User Interface Design

### Design Principles Applied
- **Nielsen's Usability Heuristics** for interface consistency
- **Norman's Design Principles** for affordances and feedback
- **Color Psychology** with warm colors to encourage browsing
- **Typography** optimized for readability (18pt+ for older users)
- **Touch Targets** minimum 48 pixels (ISO 9241-411 standard)

### Color Scheme
- **Pink** (#FF1493) - Cakes category and primary actions
- **Blue** (#1E90FF) - Drinks category
- **Gold** (#FFD700) - Specials category
- **Green** (#4CAF50) - Confirmation and success states
- **Red** (#F44336) - Warnings and allergen information

## 📊 Research & Testing

### Hierarchical Task Analysis (HTA)
Conducted comprehensive task analysis mapping 9 main user tasks:
1. Start interaction
2. Browse dessert menu
3. Search for specific item
4. Select dessert items
5. Apply loyalty discount
6. Review basket
7. Confirm and submit order
8. Order completion
9. Staff cleaning mode

### Predictive Human Error Analysis (SHERPA)
Identified and mitigated 13 potential error modes:
- Wrong selections
- Information retrieval issues
- Check omissions
- Operation errors

### Usability Testing
- **Participants:** 11 users across different age groups
- **Testing Framework:** ISO 9241 standards
- **Metrics:** Efficiency, Effectiveness, Satisfaction
- **Results:** Positive satisfaction ratings with actionable improvement suggestions

## 🏗️ Project Structure
```
SweetSpotKiosk/
├── Forms/
│   ├── WelcomeScreen.cs
│   ├── CategorySelection.cs
│   ├── ProductGrid.cs
│   ├── ProductDetail.cs
│   ├── SearchScreen.cs
│   ├── BasketReview.cs
│   ├── LoyaltyCardScanner.cs
│   ├── OrderConfirmation.cs
│   ├── OrderComplete.cs
│   ├── StaffAuthentication.cs
│   └── [20+ more screens]
├── Models/
│   ├── Product.cs
│   ├── Order.cs
│   ├── Customer.cs
│   └── LoyaltyCard.cs
├── Resources/
│   └── [Product images and icons]
└── SweetSpot.sln
```

## 🚀 How to Run

### Prerequisites
- Visual Studio 2019 or later
- .NET Framework 4.7.2 or later
- Windows OS

### Installation
1. Clone this repository:
```bash
   git clone https://github.com/ghazlanmattar-code/sweet-spot-kiosk.git
```
2. Open `SweetSpot.sln` in Visual Studio
3. Restore NuGet packages (Right-click solution → Restore NuGet Packages)
4. Build the solution (Ctrl + Shift + B)
5. Run the application (F5)

## 📸 Screenshots

### Welcome Screen
![Welcome Screen](screenshots/welcome.png)

### Category Selection
![Categories](screenshots/categories.png)

### Product Details with Allergen Warning
![Product Detail](screenshots/product-detail.png)

### Shopping Basket
![Basket](screenshots/basket.png)

### QR Code Scanner
![QR Scanner](screenshots/qr-scanner.png)

### Order Complete
![Order Complete](screenshots/order-complete.png)

## 💡 What I Learned

### Technical Challenges Overcome
1. **Layout Misalignment** - Resolved Designer vs Runtime display conflicts
2. **Type Conversion** - Fixed Bitmap to Image conversion for dynamic product loading
3. **Responsive Scaling** - Implemented dynamic font and UI scaling for different resolutions
4. **On-Screen Keyboard** - Built fully functional QWERTY keyboard with 40+ buttons
5. **Multiple Screen Architecture** - Managed navigation flow across 24+ screens

### HCI Principles Applied
- User-centered design methodology
- Iterative prototyping and testing
- Error prevention over error messages
- Consistent visual and interaction design
- Accessibility for diverse user groups

### Professional Skills Developed
- Requirements analysis
- Usability research and testing
- Technical documentation
- Problem-solving under constraints
- Attention to detail in UI/UX

## 🎯 Future Enhancements

Based on user testing feedback:
- [ ] Arabic language support (dual language toggle)
- [ ] Large text accessibility mode for visually impaired users
- [ ] Basket editing on review screen (add/remove items without going back)
- [ ] QR code for digital receipt delivery to phones
- [ ] Email validation with common domain checking
- [ ] Session timeout warning before auto-logout
- [ ] Help/Call Staff button accessible from any screen

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 👤 Author

**Ghazlan Matar**  
Second-Year Software Engineering Student  
British University of Bahrain

[![LinkedIn](https://img.shields.io/badge/LinkedIn-Connect-0077B5?style=flat-square&logo=linkedin)](https://www.linkedin.com/in/ghazlan-mattar-28378a332)
[![Email](https://img.shields.io/badge/Email-Contact-D14836?style=flat-square&logo=gmail)](mailto:ghazlanmattar@gmail.com)

## 🙏 Acknowledgments

- **Course Instructor:** [Instructor name if you want]
- **British University of Bahrain** - For providing resources and guidance
- **Usability Testing Participants** - For valuable feedback
- **Design References:** Nielsen Norman Group, ISO 9241 standards, WCAG guidelines

---

⭐ **If you found this project interesting, please consider giving it a star!**
