   M S B A M L   `   `   `  ����O  KAcademyFinal.App.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:AcademyFinal.App.WPF.ViewsAcademyFinal.App.WPF.Views  5      Q-clr-namespace:AcademyFinal.App.WPF.ViewModelsAcademyFinal.App.WPF.ViewModels  5      -    'AcademyFinal.App.WPF.Views.SubjectsView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:AcademyFinal.App.WPF.Views     5      <vm-clr-namespace:AcademyFinal.App.WPF.ViewModels     5        � 	Resources  5
      7   1AcademyFinal.App.WPF.ViewModels.SubjectsViewModel   
SubjectsVM��%   &	          5   
   6   5      .��5      �  � DataContext# [  6    � RowDefinitions 5   
   �� 5      $	��150 �6   6+   �� 5      $��* �6   6)   .+�5   
   � $��0��6   $y�Visible=�6   $��Stretch=�61   $��Stretch=�6O   ���	#FFE9F992.+�5      �� $
��Left=�6   $��Nombre Asignatura:��6/   $��	20,22,0,0q�6L   $	��Top=�6_   �� 5        errorTemplate =� ErrorTemplate# [ 6   $��Right=�6P   $��
0,26,300,0q�6l    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��347��6�   $��20��6�   .��6�   ��5      �� 5       �� Path$
 Name�6    �� ValidatesOnDataErrors$
 True��6*    �� UpdateSourceTrigger$ PropertyChanged=�6H    �� ValidationRules 5      6   0AcademyFinal.App.WPF.Views.StudentDataValidation  5      	   MinimunCharacters$	 5��6:   5      .��5        5!      �� 5$      $
��Left=�6   $�� Techer:��6/   $��	17,55,0,0q�6B   $	��Top=�6U   �� 5%      $
��Left=�6   $��	153,0,0,0q�61   $
 Wrap=�6D   $��Center=�6X   $	��347��6s   $��20��6   .��6�   ��5&      �� 5'      $ Teacher�6   $
 True��6-   $ PropertyChanged=�6K    5(        5)      $	 5��6:   5-      .��5.       5/      �� 52      -   5        
 ��Name$
 Editar��52      $��Editar Asignatura��6%   $��652,97,23,24q�6j   ���	#FF00D7D3��6A   �� *UpdateSubjectCommand+6�   �� 54      -   5        $
 Guardar��54      $��Añadir Asignatura��6&   $��652,57,23,64q�6h   ���	#FF00D7D3��6B   �� *AddSubjectCommand+6�   56      � 57   
   $��1��6    58      �� 59      $��* �6    6-   �� 5:      $��40 �6    6.   .+�5=      � $��0��6   .+�5>      �� -   5         ��Name$ lbx_Subjects��5>      $��0,5,0,5q�6T   ���	#FFA4EBDD��60   �� *SubjectList+ �� SelectedItem 6�   �� *SelectedSubject+��5?      �� 5@       �� EndPoint$ 0.5,1&�6.    �� 
StartPoint$ 0.5,0&�6?   .��5A      �  � Color$ Black��6+    � Offset$ 0.979Q�69   � 5B      $ 	#FFA4EBDD��6+   $ 1Q�6=   5C      5E      5G      � 5I      $��1��6   .+�5J      �� $
��Left=�6>   ���	#FFE9F992��6   �� *SubjectList.Count+6a   �� 5K      $��Get Subjects��6   $	��125��6W   $��	654,5,0,5q�6c   $
��Left=�6v   ���	#FF2CDDD3��60   �� *GetSubjectsCommand+6�   5L      5N      5T      5Y      