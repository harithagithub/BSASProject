   M S B A M L   `   `   `  ����B  >WpfApp8, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp8WpfApp8  5   	       BSASGUI.StaffDashboard   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp8     5   	   
�������  � Title$  StaffDashboard��5	   	   $	��500��6    $	��800��6-   .��5
      �  � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $��50 �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $	��500 �6   .+�5   
   �� $��0��6   $��0��6#    �� Orientation$ 
Horizontal=�63   .+�5      �� -   5         ��Name$ 
txtSearch1��5      $��26��6*   $	��100��66   $
��10,5q�6B   �� 5      -   5         ��Name$ 
btnSearch1��5      $��Search��6)   $��26��6:   $	��100��6G   $
��5,10q�6S   6a   5      �� 5!   
   $��0��6   $��1��6#   $ 
Horizontal=�63   .+�5#      �� -   5        $ btnProduct1��5#      $��Products��6*   $��26��6=   $	��100��6J   $��85,10q�6V   6e   �� 5$      -   5        $ btnAppointment��5$      $��Appointments��6-   $��26��6D   $	��100��6Q   $��-50,10q�6]   6m   �� 5%      -   5        $ 
btnLogout1��5%      $��Logout��6)   $��26��6:   $	��100��6G   $��90,22q�6S   6b   5&      ]� 5'   
   $��1��6   $��0��6!   $��2��61   $��
5,5,5,-226q�6E   .+�5(      �� $��3q�6   
���   � �� CornerRadius$ 10��6=    �� Padding$ 4q�6O   $��
0,0,0,-112q�6\   $	��752��6p    J� Effect 5)      3  -System.Windows.Media.Effects.DropShadowEffect  5*      	   Color$
	 Gray��6'   
   Opacity$
 .5Q�5+   '      ShadowDepth$ 4Q�5,   '   ._�5.       � -   5        $��frmMain��5.        � NavigationUIVisibility$ Hidden=�6'   $��	0,3,0,121q�6G   $	��770��6Z   5/      51      58      59      