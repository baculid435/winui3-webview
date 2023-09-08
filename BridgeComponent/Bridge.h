#pragma once

#include "Bridge.g.h"

namespace winrt::BridgeComponent::implementation
{
    struct Bridge : BridgeT<Bridge>
    {
        Bridge() = default;

        int32_t MyProperty();
        void MyProperty(int32_t value);
    };
}

namespace winrt::BridgeComponent::factory_implementation
{
    struct Bridge : BridgeT<Bridge, implementation::Bridge>
    {
    };
}
