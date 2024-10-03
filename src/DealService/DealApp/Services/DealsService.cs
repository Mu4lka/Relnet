using DealApiContracts.Dto;
using DealApiContracts.Requests;
using DealApp.Services.Interfaces;
using DealDomain;
using DealDomain.Entities;
using DealDomain.Enums;
using DealDomain.Obstructions.Repositories;
using DealDomain.Utils;

namespace DealApp.Services;

/// <summary>
/// Сервис сделок
/// </summary>
public class DealsService(IDealsRepository _dealsRepository, ITimeProvider _timeProvider) : IDealsService
{
    public async Task<Result<Guid>> CreateAsync(CreateDealRequest request)
    {
        var deal = new Deal()
        {
            CreatedTime = _timeProvider.UtcNow,
            Status = DealStatus.New,
            CustomerFullName = request.CustomerFullName,
            CustomerPhoneNumber = request.CustomerPhoneNumber,
            CustomerCity = request.CustomerCity,
            CustomerAddress = request.CustomerAddress,
            Provider = request.Provider,
            Tariff = request.Tariff,
            AdditionalInformation = request.AdditionalInformation,
            NumberOfServices = request.NumberOfServices,
            RealtorId = request.RealtorId,
            SourceId = request.SourceId,
            Payment = request.Payment,
            ResponsibleUserId = request.ResponsibleUserId,
        };

        var quizId = await _dealsRepository.CreateAsync(deal);
        return Result.Ok(quizId);
    }

    public async Task<Result> DeleteAsync(Guid id)
    {
        await _dealsRepository.DeleteAsync(id);
        return Result.Ok();
    }

    public async Task<Result<ICollection<GetDealDto>>> GetByFilterAsync()
    {
        var deals = await _dealsRepository.GetByFilterAsync();

        var dealsDtos = deals.Select(d => new GetDealDto()
        {
            Id = d.Id,
            CreatedTime = d.CreatedTime,
            Status = (byte)d.Status,
            CustomerFullName = d.CustomerFullName,
            CustomerPhoneNumber = d.CustomerPhoneNumber,
            CustomerCity = d.CustomerCity,
            CustomerAddress = d.CustomerAddress,
            Provider = d.Provider,
            Tariff = d.Tariff,
            AdditionalInformation = d.AdditionalInformation,
            NumberOfServices = d.NumberOfServices,
            Realtor = d.Realtor is null ? null : new GetRealtorDto()
            {
                Id = d.Realtor.Id,
                Name = d.Realtor.Name,
                PhoneNumber = d.Realtor.PhoneNumber,
            },
            Source = new GetSourceDto()
            {
                Id = d.Source.Id,
                Title = d.Source.Title,
                Url = d.Source.Url,
            },
            Payment = d.Payment,
            ResponsibleUserId = d.ResponsibleUserId
        }).ToList();

        return Result.Ok<ICollection<GetDealDto>>(dealsDtos);
    }

    public Task<Result> UpdateAsync(UpdateDealRequest request)
    {
        throw new NotImplementedException();
    }

    public async Task<Result> UpdateStatusAsync(UpdateDealStatusRequest request)
    {
        await _dealsRepository.UpdateStatusAsync(request.DealId, (DealStatus)request.DealStatus);
        return Result.Ok();
    }
}
