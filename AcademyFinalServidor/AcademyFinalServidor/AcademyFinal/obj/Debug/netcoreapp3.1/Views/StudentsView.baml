   M S B A M L   `   `   `  ����O  KAcademyFinal.App.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:AcademyFinal.App.WPF.ViewModelsAcademyFinal.App.WPF.ViewModels  5      G(clr-namespace:AcademyFinal.App.WPF.ViewsAcademyFinal.App.WPF.Views  5      -    'AcademyFinal.App.WPF.Views.StudentsView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <vm-clr-namespace:AcademyFinal.App.WPF.ViewModels     5      :local(clr-namespace:AcademyFinal.App.WPF.Views     5        � 	Resources  5      7   1AcademyFinal.App.WPF.ViewModels.StudentsViewModel   
StudentsVM��%   &	          5   
   6   5      .��5      �  � DataContext# [  6    � RowDefinitions 5   
   �� 5      $	��150 �6   6+   �� 5      $��* �6   6)   .+�5   
   � $��0��6   $y�Visible=�6   $��Stretch=�61   $��Stretch=�6O   ���	#FF83CDC6 � ColumnDefinitions 5      �� 5      $��5* �6#   �� 5      $	��27* �6#   .+�5      �� $
��Left=�6   $��Nombre Estudiante:��6/   $��	26,25,0,0q�6L   $	��Top=�6_   $��2��6w   �� 5        errorTemplate =� ErrorTemplate# [ 6   $��Right=�6P   $��
0,29,267,0q�6l    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��347��6�   $��20��6�   $��1��6�   .��6�   ��5      �� 5       �� Path$
 Name�6    �� ValidatesOnDataErrors$
 True��6*    �� UpdateSourceTrigger$ PropertyChanged=�6H   	 �� ValidationRules	 5      6   0AcademyFinal.App.WPF.Views.StudentDataValidation  5       
   MinimunCharacters$
 5��6:   5$      .��5%       5&      �� 5)      $
��Left=�6   $��DNI Estudiante:��6/   $��	26,58,0,0q�6I   $	��Top=�6\   �� 5*      $
��Left=�6   $��63,0,0,0q�61   $
 Wrap=�6C   $��Center=�6W   $	��345��6r   $��20��6~   $��1��6�   .��6�   ��5+      �� 5,      $	 Dni�6   $
 True��6)   $ PropertyChanged=�6G   	 5-        5.      $
 5��6:   52      .��53       54      �� 56      $
��Left=�6   $��Número silla asignada:��6/   $��	26,94,0,0q�6P   $	��Top=�6c   $��2��6{   �� 57      $
��Left=�6   $��	63,99,0,0q�61   $
 Wrap=�6b   $	��Top=�6v   $	��120��6�   $��21��6�   $��1��6�   ��6D   �� *ChairNumber+6�   �� 59      -   5         ��Name$ Editar��59      $��Editar Estudiante��6%   $��524,80,26,41q�6j   ���	#FF00D7D3$��1��6�   ��6A   �� *UpdateStudentCommand+6�   �� 5;      -   5        $ Guardar��5;      $��Añadir Estudiante��6&   $��524,36,26,85q�6h   ���	#FF00D7D3$��1��6�   ��6B   �� *AddStudentCommand+6�   5=      � 5>   
   $��1��6    5?      �� 5@      $��* �6    6-   �� 5A      $��40 �6    6.   .+�5D      � $��0��6   .+�5E      �� -   5         ��Name$ lbx_Students��5E      $��0,5,0,5q�6W   ��62   �� *StudentsList+ �� SelectedItem 6�   �� *SelectedStudent+.@�5F      �� .P�5G      �� $
��Name��6)    �� Width$	 120��67    �� DisplayMemberBinding 6C   �� *Name+�� 5H      $	��Dni��6)   $ 50��66    6A   �� *Dni+�� 5I      $��Silla��6)   $	 150��68    6D   �� *ChairNumber+ �� CellTemplate 5J      �� 5K   "   .R�5L      �� 5M      5O      5Q      5T      5V      � 5X      $��1��6   .+�5Y      �� $
��Left=�6?   ���	#FF83CDC6��6   �� *StudentsList.Count+6b   �� 5Z      $��Get Students��6   $	��100��6W   $��	675,5,0,5q�6c   $
��Left=�6v   ���	#FF2CDDD3��60   �� *GetStudentsCommand+6�   5[      5]      5c      5h      