#include "pch.h"
#include "Bridge.h"
#include "Bridge.g.cpp"

namespace winrt::BridgeComponent::implementation
{
    int32_t Bridge::MyProperty()
    {
        return 2;
    }

    void Bridge::MyProperty(int32_t /* value */)
    {
        throw hresult_not_implemented();
    }
}
