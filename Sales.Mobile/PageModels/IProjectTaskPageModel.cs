using CommunityToolkit.Mvvm.Input;
using Sales.Mobile.Models;

namespace Sales.Mobile.PageModels;

public interface IProjectTaskPageModel
{
	IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
	bool IsBusy { get; }
}