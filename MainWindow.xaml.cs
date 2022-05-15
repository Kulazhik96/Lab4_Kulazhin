using System;
using Lab4_Kulazhin.Default_Messages;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab4_Kulazhin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Rectangle firstRectangle = null;
        private Rectangle secondRectangle = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        // To keep default text in input TextBoxes.
        private void BottomLeftRectanglePoint_2_GotFocus(object sender, RoutedEventArgs e)
        {
            BottomLeftRectanglePoint_2.Text = string.Empty;
            BottomLeftRectanglePoint_2.LostFocus += (sender, e) =>
            {
                if (BottomLeftRectanglePoint_2.Text == string.Empty)
                { BottomLeftRectanglePoint_2.Text = DefaultMessages.ShowMessage(DefaultMessages.Message.EnterCoordinates); }
            };
        }

        private void BottomLeftRectanglePoint_1_GotFocus(object sender, RoutedEventArgs e)
        {
            BottomLeftRectanglePoint_1.Text = string.Empty;
            BottomLeftRectanglePoint_1.LostFocus += (sender, e) =>
            {
                if (BottomLeftRectanglePoint_1.Text == string.Empty)
                { BottomLeftRectanglePoint_1.Text = DefaultMessages.ShowMessage(DefaultMessages.Message.EnterCoordinates); }
            };
        }

        private void LengthRectangle_1_GotFocus(object sender, RoutedEventArgs e)
        {
            LengthRectangle_1.Text = string.Empty;
            LengthRectangle_1.LostFocus += (sender, e) =>
            {
                if (LengthRectangle_1.Text == string.Empty)
                { LengthRectangle_1.Text = DefaultMessages.ShowMessage(DefaultMessages.Message.EnterLength); }
            };
        }

        private void WidthRectangle_1_GotFocus(object sender, RoutedEventArgs e)
        {
            WidthRectangle_1.Text = string.Empty;
            WidthRectangle_1.LostFocus += (sender, e) =>
            {
                if (WidthRectangle_1.Text == string.Empty)
                { WidthRectangle_1.Text = DefaultMessages.ShowMessage(DefaultMessages.Message.EnterWidth); }
            };
        }

        private void LengthRectangle_2_GotFocus(object sender, RoutedEventArgs e)
        {
            LengthRectangle_2.Text = string.Empty;
            LengthRectangle_2.LostFocus += (sender, e) =>
            {
                if (LengthRectangle_2.Text == string.Empty)
                { LengthRectangle_2.Text = DefaultMessages.ShowMessage(DefaultMessages.Message.EnterLength); }
            };
        }

        private void WidthRectangle_2_GotFocus(object sender, RoutedEventArgs e)
        {
            WidthRectangle_2.Text = string.Empty;
            WidthRectangle_2.LostFocus += (sender, e) =>
            {
                if (WidthRectangle_2.Text == string.Empty)
                { WidthRectangle_2.Text = DefaultMessages.ShowMessage(DefaultMessages.Message.EnterWidth); }
            };
        }

        // Operations TextBoxes.
        private void ResizeRectangle_1Length_GotFocus(object sender, RoutedEventArgs e)
        {
            ResizeRectangle_1Length.Text = string.Empty;
            ResizeRectangle_1Length.LostFocus += (sender, e) =>
            {
                if (ResizeRectangle_1Length.Text == string.Empty)
                { ResizeRectangle_1Length.Text = DefaultMessages.ShowMessage(DefaultMessages.Message.SetNewLength); }
            };
        }

        private void ResizeRectangle_1Width_GotFocus(object sender, RoutedEventArgs e)
        {
            ResizeRectangle_1Width.Text = string.Empty;
            ResizeRectangle_1Width.LostFocus += (sender, e) =>
            {
                if (ResizeRectangle_1Width.Text == string.Empty)
                { ResizeRectangle_1Width.Text = DefaultMessages.ShowMessage(DefaultMessages.Message.SetNewWidth); }
            };
        }

        private void MoveRectangle_X_GotFocus(object sender, RoutedEventArgs e)
        {
            MoveRectangle_X.Text = string.Empty;
            MoveRectangle_X.LostFocus += (sender, e) =>
            {
                if (MoveRectangle_X.Text == string.Empty)
                { MoveRectangle_X.Text = DefaultMessages.ShowMessage(DefaultMessages.Message.SetNewX); }
            };
        }

        private void MoveRectangle_Y_GotFocus(object sender, RoutedEventArgs e)
        {
            MoveRectangle_Y.Text = string.Empty;
            MoveRectangle_Y.LostFocus += (sender, e) =>
            {
                if (MoveRectangle_Y.Text == string.Empty)
                { MoveRectangle_Y.Text = DefaultMessages.ShowMessage(DefaultMessages.Message.SetNewY); }
            };
        }

        // Buttons.
        private void CreateRectangles_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                GetCoordinates(BottomLeftRectanglePoint_1.Text, out double x1, out double y1);
                GetCoordinates(BottomLeftRectanglePoint_2.Text, out double x2, out double y2);

                firstRectangle = new(new TwoDimensionPoint(x1, y1), GetDoubleFromTextBox(LengthRectangle_1), GetDoubleFromTextBox(WidthRectangle_1));
                FirstRectangleLeftBottomPoint_Show.Text = string.Format($"{firstRectangle.StartPoint.X};{firstRectangle.StartPoint.Y}");
                FirstRectangleLength_Show.Text = firstRectangle.Length.ToString();
                FirstRectangleWidth_Show.Text = firstRectangle.Width.ToString();

                secondRectangle = new(new TwoDimensionPoint(x2, y2), GetDoubleFromTextBox(LengthRectangle_2), GetDoubleFromTextBox(WidthRectangle_2));
                SecondRectangleLeftBottomPoint_Show.Text = string.Format($"{secondRectangle.StartPoint.X};{secondRectangle.StartPoint.Y}");
                SecondRectangleLength_Show.Text = secondRectangle.Length.ToString();
                SecondRectangleWidth_Show.Text = secondRectangle.Width.ToString();
            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ClearInput_Click(object sender, RoutedEventArgs e)
        {
            BottomLeftRectanglePoint_1.Text = DefaultMessages.ShowMessage(DefaultMessages.Message.EnterCoordinates);
            BottomLeftRectanglePoint_2.Text = DefaultMessages.ShowMessage(DefaultMessages.Message.EnterCoordinates);
            LengthRectangle_1.Text = DefaultMessages.ShowMessage(DefaultMessages.Message.EnterLength);
            WidthRectangle_1.Text = DefaultMessages.ShowMessage(DefaultMessages.Message.EnterWidth);
            LengthRectangle_2.Text = DefaultMessages.ShowMessage(DefaultMessages.Message.EnterLength);
            WidthRectangle_2.Text = DefaultMessages.ShowMessage(DefaultMessages.Message.EnterWidth);
            ResizeRectangle_1Length.Text = DefaultMessages.ShowMessage(DefaultMessages.Message.SetNewLength);
            ResizeRectangle_1Width.Text = DefaultMessages.ShowMessage(DefaultMessages.Message.SetNewWidth);
            MoveRectangle_X.Text = DefaultMessages.ShowMessage(DefaultMessages.Message.SetNewX);
            MoveRectangle_Y.Text = DefaultMessages.ShowMessage(DefaultMessages.Message.SetNewY);
            firstRectangle = null;
            secondRectangle = null;
        }

        private void ClearOutput_Click(object sender, RoutedEventArgs e)
        {
            FirstRectangleLeftBottomPoint_Show.Text = string.Empty;
            FirstRectangleLength_Show.Text = string.Empty;
            FirstRectangleWidth_Show.Text = string.Empty;

            SecondRectangleLeftBottomPoint_Show.Text = string.Empty;
            SecondRectangleLength_Show.Text = string.Empty;
            SecondRectangleWidth_Show.Text = string.Empty;

            IntersectionRectangleLeftBottomPoint_Show.Text = string.Empty;
            IntersectionRectangleLength_Show.Text = string.Empty;
            IntersectionRectangleWidth_Show.Text = string.Empty;

            LeastContainsBothRectangleLeftBottomPoint_Show.Text = string.Empty;
            LeastContainsBothRectangleLength_Show.Text = string.Empty;
            LeastContainsBothRectangleWidth_Show.Text = string.Empty;
        }

        private void RunOperation_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (firstRectangle == null && secondRectangle == null)
                    throw new ArgumentNullException("Create both rectangles first!");

                if ((bool)ResizeFirstRectangle.IsChecked)
                {
                    firstRectangle.Resize(GetDoubleFromTextBox(ResizeRectangle_1Length), GetDoubleFromTextBox(ResizeRectangle_1Width));
                    FirstRectangleLength_Show.Text = firstRectangle.Length.ToString();
                    FirstRectangleWidth_Show.Text = firstRectangle.Width.ToString();
                    return;
                }
                if ((bool)ResizeSecondRectangle.IsChecked)
                {
                    secondRectangle.Resize(GetDoubleFromTextBox(ResizeRectangle_1Length), GetDoubleFromTextBox(ResizeRectangle_1Width));
                    SecondRectangleLength_Show.Text = secondRectangle.Length.ToString();
                    SecondRectangleWidth_Show.Text = secondRectangle.Width.ToString();
                    return;
                }
                if ((bool)MoveFirstRectangle.IsChecked)
                {
                    firstRectangle.Move(GetDoubleFromTextBox(MoveRectangle_X), GetDoubleFromTextBox(MoveRectangle_Y));
                    FirstRectangleLeftBottomPoint_Show.Text = string.Format($"{firstRectangle.StartPoint.X};{firstRectangle.StartPoint.Y}");
                    return;
                }
                if ((bool)MoveSecondRectangle.IsChecked)
                {
                    secondRectangle.Move(GetDoubleFromTextBox(MoveRectangle_X), GetDoubleFromTextBox(MoveRectangle_Y));
                    SecondRectangleLeftBottomPoint_Show.Text = string.Format($"{secondRectangle.StartPoint.X};{secondRectangle.StartPoint.Y}");
                    return;
                }
                if ((bool)GetIntersectionRadioButton.IsChecked)
                {
                    Rectangle intersection = Rectangle.CreateNewIntersection(firstRectangle, secondRectangle);
                    IntersectionRectangleLeftBottomPoint_Show.Text = string.Format($"{intersection.StartPoint.X};{intersection.StartPoint.Y}");
                    IntersectionRectangleLength_Show.Text = intersection.Length.ToString();
                    IntersectionRectangleWidth_Show.Text = intersection.Width.ToString();
                    return;
                }
                if ((bool)GetLeastIncludingBothRadioButton.IsChecked)
                {
                    Rectangle leastContainsBoth = Rectangle.CreateNewLeastConsistingTwo(firstRectangle, secondRectangle);
                    LeastContainsBothRectangleLeftBottomPoint_Show.Text = string.Format($"{leastContainsBoth.StartPoint.X};{leastContainsBoth.StartPoint.Y}");
                    LeastContainsBothRectangleLength_Show.Text = leastContainsBoth.Length.ToString();
                    LeastContainsBothRectangleWidth_Show.Text = leastContainsBoth.Width.ToString();
                    return;
                }

                MessageBox.Show("Chose an operation!", "Info", MessageBoxButton.OK, MessageBoxImage.Question);
            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Assistive methods.
        private static void GetCoordinates(string source, out double x, out double y)
        {
            string[] tempStorage = source.Split(';');
            if (tempStorage.Length != 2)
                throw new IndexOutOfRangeException("Incorrect input left-bottom point coordinates!");

            if (!double.TryParse(tempStorage[0], out x) && !double.TryParse(tempStorage[1], out y))
                throw new ArgumentException("Incorrect input left-bottom point coordinates!");
            else
            {
                x = double.Parse(tempStorage[0]);
                y = double.Parse(tempStorage[1]);
            }
        }

        private static double GetDoubleFromTextBox(TextBox box)
        {
            if (!double.TryParse(box.Text, out double side))
                throw new FormatException("Incorrect input!");
            else
                return double.Parse(box.Text);
        }
    }
}
