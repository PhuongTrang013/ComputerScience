@automated
Feature: US04_PPCRentalViewlist
	As a user
	I want to be she list of project

Background:
Given following the projects
| Project Name            | District  | Ward    | Street     | Price | Project Type | Status   |
| Saigon Pearl Ruby Block | Chương Mỹ | Đại Yên | Ấp Tân Lập | 30000 | Apartmenr    | Đã duyệt |

Scenario: Check Property Name Of The List
	When I click DUAN
	Then I should see the list of project
	| Project Name            |
	| Saigon Pearl Ruby Block |
